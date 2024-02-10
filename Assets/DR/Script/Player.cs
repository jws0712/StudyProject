using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public AudioSource source;
    //public AudioClip clip;
    //public AudioClip clip_2;
    //public GameManager_02 GM;
    Rigidbody2D rb;
    //Animator Anim;
    public float JumpPower = 5f;
    //private bool IsJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Anim = GetComponent<Animator>();
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        //GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager_02>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (GM.IsDead)
        //{
        //    return;
        //}
        if (Input.GetKeyDown(KeyCode.Space)) //&& IsJump)
        {
            rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
            //IsJump = false;
            //source.clip = clip;
            //source.Play();
            //Anim.SetBool("IsJump", true);
            //Anim.SetBool("IsColl", false);


        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    IsJump = true;
    //    Anim.SetBool("IsColl", true);
    //    Anim.SetBool("IsJump", false);

    //    if (collision.gameObject.CompareTag("Money"))
    //    {

    //        AudioClip myclip = clip_2;
    //        source.PlayOneShot(myclip);
    //        GM.IsDead = true;

    //        GameObject ui = GameObject.Find("UICon");

    //        UICon_02 sm = ui.GetComponent<UICon_02>();

    //        if (sm.FinScore > sm.BestSc)
    //        {
    //            sm.BestSc = sm.FinScore;

    //            PlayerPrefs.SetFloat("Best Socre", sm.BestSc);
    //        }
    //    }




    //}
}

