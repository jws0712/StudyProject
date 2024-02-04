using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_02 : MonoBehaviour
{
    public float Speed;
    public float SpawnRate;

    public float minRate;

    public float maxRate;

    public bool IsDead = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        Speed += Time.deltaTime * 1 / 100;
        
        SpawnRate = Random.Range(minRate, maxRate);
    }
}
