using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; 
    public Rigidbody rb; 

    Vector3 movement;

    //public GameObject endScene;

    private void Start()
    {
        //endScene.SetActive(false);
    }



    void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        
        movement = new Vector3(moveHorizontal, 0f, moveVertical).normalized;
    }

    void FixedUpdate()
    {
        
        rb.AddForce(movement * moveSpeed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    
    
}



