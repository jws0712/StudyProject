using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    GameManager_02 GM;
    Vector3 dir = Vector3.left;
    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager_02>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GM.IsDead)
        {
            return;
        }
        transform.position += dir * GM.Speed * Time.deltaTime;
        

        if(transform.position.x <= -16)
        {
            Destroy(gameObject);
        }
    }
}
