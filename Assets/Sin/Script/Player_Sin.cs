using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Sin : MonoBehaviour
{
    public float Speed = 5f;

    public GameObject Bullet;

    public Transform FirePos;

    public bool IsBullet = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -8)
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && transform.position.x <= 8)
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!IsBullet)
            {
                Instantiate(Bullet, FirePos.position, Quaternion.identity);
                IsBullet = true;
            }
            
        }

    }


}
