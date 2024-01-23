using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigd;

    public AudioSource source;
    public AudioClip clip;
    public AudioClip clip2;
    public float Speed;
    public LogicScript logic;
    public Collider2D myColl;
    public bool IsDead = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsDead)
        {
            myrigd.velocity = Vector2.up * Speed;
            source.clip = clip;
            source.Play();
        }

        if (transform.position.y >= 17 || transform.position.y <= -17)
        {   
            GameOver();
            Destroy(this.gameObject);

        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
        source.clip = clip2;
        source.Play();
    }

    private void GameOver()
    {
        myColl.isTrigger = true;
        logic.gameOver();
        IsDead = false;
    }
}
