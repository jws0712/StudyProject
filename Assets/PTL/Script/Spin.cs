using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public GameManager GameManager;
    public float Plus;

    public float SpinSpeed;
    Vector3 Zaxis = new Vector3(0, 0, 1);

    void Update()
    {
        if(GameManager.IsDead == false)
        {
            transform.RotateAround(transform.position, Zaxis, SpinSpeed * Time.deltaTime);
        }
        

        if (Input.GetKeyDown(KeyCode.Space) && GameManager.OnStick == true)
        {
            SpinSpeed *= -1;
            if (SpinSpeed > 0)
                SpinSpeed += Plus;
            else
                SpinSpeed -= Plus;
            GameManager.AttackBall = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.GameOver();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        GameManager.OnStick = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameManager.OnStick = false;
    }
}   
