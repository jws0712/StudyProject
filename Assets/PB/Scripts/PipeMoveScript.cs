using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    public BirdScript Bird;

    // Start is called before the first frame update
    void Start()
    {
        Bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.IsDead)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
            if(transform.position.x < deadZone)
            {
                Destroy(gameObject);
            }
        }

    }
}
