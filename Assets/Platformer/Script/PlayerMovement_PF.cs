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
    public bool IsAttack = false;
    public float ForwordAttack = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && IsGround && IsAttack == false)
        {
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            IsGround = false;
            anim.SetBool("IsJumping", true);
        }

        if (Input.GetMouseButtonDown(0) && IsAttack == false && IsGround == true)
        {
            anim.SetTrigger("Attack");
            IsAttack = true;
            StartCoroutine(AttackTime());
        }

    }

    IEnumerator AttackTime()
    {
        yield return new WaitForSeconds(1.3f);
        IsAttack = false;

    }

    private void FixedUpdate()
    {
        if(IsAttack == false)
        {

            float x = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(x * Speed, rb.velocity.y);
            anim.SetFloat("yVelocity", rb.velocity.y);
            anim.SetBool("Walk", true);



            if (rb.velocity.x > 0)
            {
                transform.localScale = new Vector3(4, 4, 4);
                

            }
            else if (rb.velocity.x < 0)
            {
                transform.localScale = new Vector3(-4, 4, 4);




            }

            else if(rb.velocity.x == 0)
            {

                anim.SetTrigger("Idle");
                anim.SetBool("Walk", false);
            }
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            rb.velocity = new Vector2(0, rb.velocity.y);
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
    private void OnTriggerExit2D(Collider2D collision)
    {
            anim.SetBool("IsJumping", true);

        
    }




}
