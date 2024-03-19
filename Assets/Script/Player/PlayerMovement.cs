using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; // ความเร็วของการเคลื่อนที่
    public Rigidbody rb; // Rigidbody สำหรับเคลื่อนที่

    Vector3 movement; // เก็บเวกเตอร์การเคลื่อนที่

    void Update()
    {
        // Input จากผู้เล่น
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // กำหนดเวกเตอร์การเคลื่อนที่
        movement = new Vector3(moveHorizontal, 0f, moveVertical).normalized;
    }

    void FixedUpdate()
    {
        // การเคลื่อนที่ด้วย Constant Force
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



