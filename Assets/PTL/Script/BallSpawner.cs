
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameManager GameManager;


    public GameObject ball;
    public float radius = 5f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
        GameManager.IsBall = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.AttackBall == false && GameManager.IsBall == false)
        {
            SpawnBall();
            GameManager.IsBall = true;
        }
    }

    public void SpawnBall()
    {
        float angle = Random.Range(0f, 360f);

        
        float x = transform.position.x + radius * Mathf.Cos(angle * Mathf.Deg2Rad);
        float y = transform.position.y + radius * Mathf.Sin(angle * Mathf.Deg2Rad);

        
        Vector3 spawnPosition = new Vector3(x, y, transform.position.z);
        Instantiate(ball, spawnPosition, Quaternion.identity);
    }
}
