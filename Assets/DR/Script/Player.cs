using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator Anim;
    public float JumpPower = 5f;
    private bool IsJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsJump)
        {
            rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
            IsJump = false;
            Anim.SetBool("IsJump", true);
            Anim.SetBool("IsColl", false);


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsJump = true;
        Anim.SetBool("IsColl", true);
        Anim.SetBool("IsJump", false);
    }
}

