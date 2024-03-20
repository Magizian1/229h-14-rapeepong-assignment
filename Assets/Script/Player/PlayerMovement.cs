using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody rb;
    public float airResistance = 0.1f; 

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical).normalized;

        
        Vector3 force = movement * moveSpeed;

        
        Vector3 airResistanceForce = -rb.velocity * airResistance;

        
        Vector3 totalForce = force + airResistanceForce;

        
        rb.AddForce(totalForce, ForceMode.Force);
    }



}



