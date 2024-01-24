using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GM.AttackBall == true)
        {
            Destroy(gameObject);
            GM.AddScore();
            GM.AttackBall = false;
            GM.IsBall = false;
        }
    }

}
