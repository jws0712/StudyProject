using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Sin : MonoBehaviour
{

    public float Speed = 5f;

    public GameObject bullet;

    public GameObject FirePos;

    public bool IsBullet = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x > -4)
        {
            Vector3 dir = new Vector3(-1, 0, 0);
            transform.position += dir * Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && transform.position.x < 4)
        {
            Vector3 dir = new Vector3(1, 0, 0);
            transform.position += dir * Speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(IsBullet == false)
            {
                Instantiate(bullet, FirePos.transform.position, Quaternion.identity);
                IsBullet = true;
            }
        }
    }

}
