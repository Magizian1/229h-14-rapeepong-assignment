using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float speed = 3f;
    public float jump = 10f;

    private Rigidbody2D rb;
    private bool facingRight = true;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            Flip();
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            FlipBack();
            
        }


    }
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        // เช่น ถ้าตำแหน่ง X เปลี่ยนไป
        if (move != 0)
        {
            // เล่น Animation Clip ที่ชื่อ "Walk" ใน Animator Controller
            animator.Play("RunAnim");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("JumpAnim");
        }
        else
        {
            // เล่น Animation Clip ที่ชื่อ "Idle" ใน Animator Controller
            animator.Play("PlayerAnim");
        }
    }

    void Flip()
    {
        // กลับด้านตัวละครเมื่อกดปุ่ม A
        facingRight = false;
        Vector3 newScale = transform.localScale;
        newScale.x = -1;
        transform.localScale = newScale;
    }
    void FlipBack()
    {
        // กลับด้านตัวละครเมื่อกดปุ่ม A
        facingRight = true;
        Vector3 newScale = transform.localScale;
        newScale.x = 1;
        transform.localScale = newScale;
    }
   
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }*/
}
