using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController2D : MonoBehaviour
{
    public float speed = 3f;
    public float jump = 10f;
    private bool isGrounded;

    private Rigidbody2D rb;
    private bool facingRight = true;

    private Animator animator;

    public Transform shootPoint;
    public Rigidbody2D bullet;

    public AudioClip fireBullet;
    public AudioSource fireBu;

    public AudioClip audioClip;
    public AudioSource audioSource;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        fireBu = GetComponent<AudioSource>();
        fireBullet = GetComponent<AudioClip>();
        audioClip = GetComponent<AudioClip>();
        audioSource = GetComponent<AudioSource>();
        
    }

    
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
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

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            Vector2 projectileV = CalculateProjectile(shootPoint.position, hit.point, 1);

            Rigidbody2D spawnBullet = Instantiate(bullet, shootPoint.position, Quaternion.identity);
            spawnBullet.velocity = projectileV;
            //fireBu.Play();
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

    

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            UIInGame.Instance.ScoreUp();
            audioSource.Play();
            
        }

        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Water"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Goal"))
        {
            SceneManager.LoadScene("EndGame");
        }
    }

    Vector2 CalculateProjectile(Vector2 origin, Vector2 targetPoint, float time)
    {
        Vector2 distance = targetPoint - origin;
        float velocityX = distance.x / time;
        float velocityY = distance.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y) * time;

        Vector2 projecttileVelocity = new Vector2(velocityX, velocityY);

        return projecttileVelocity;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Water"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Water"))
        {
            isGrounded = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            isGrounded = false;
        }
    }
}
