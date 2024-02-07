using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Sin : MonoBehaviour
{
    public float Speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Speed * Time.deltaTime;
    }
}
