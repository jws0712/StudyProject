using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Sin : MonoBehaviour
{
    public Player_Sin Player;
    public GameObject Effect;
    Rigidbody2D rb;
    public float Speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Player_Sin>();
        rb = GetComponent<Rigidbody2D>();
        

    }
    private void FixedUpdate()
    {
        transform.position += Vector3.up * Speed * Time.deltaTime;
    }


    // Update is called once per frame
 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(Effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Player.IsBullet = false;
    }

}
