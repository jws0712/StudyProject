using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Ro02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 dir = new Vector3(transform.position.x, -1.08f, transform.position.z);


        transform.position = dir;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
