using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; // �������Ǣͧ�������͹���
    public Rigidbody rb; // Rigidbody ����Ѻ����͹���

    Vector3 movement; // ���ǡ����������͹���

    void Update()
    {
        // Input �ҡ������
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // ��˹��ǡ����������͹���
        movement = new Vector3(moveHorizontal, 0f, moveVertical).normalized;
    }

    void FixedUpdate()
    {
        // �������͹������ Constant Force
        rb.AddForce(movement * moveSpeed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    public string sceneToLoad;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Goal")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}



