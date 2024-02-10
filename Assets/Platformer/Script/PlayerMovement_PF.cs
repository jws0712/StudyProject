using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_PF : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    public float jumpPower;
    public float Speed;
    public bool IsGround = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && IsGround)
        {
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            IsGround = false;
            anim.SetBool("IsJumping", true);
            
        }
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * Speed, rb.velocity.y);
        anim.SetFloat("yVelocity", rb.velocity.y);


        if (rb.velocity.x > 0)
        {
            transform.rotation = Quaternion.Euler(Quaternion.identity.x, 0, Quaternion.identity.y);
            anim.SetTrigger("Walk");

        }
        else if (rb.velocity.x < 0)
        {
            transform.rotation = Quaternion.Euler(Quaternion.identity.x, 180, Quaternion.identity.y);
            anim.SetTrigger("Walk");


        }

        else
        {
            
            anim.SetTrigger("Idle");
        }

        


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGround = true;
            anim.SetBool("IsJumping", false);


        }
    }




}
