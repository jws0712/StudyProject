using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawn : MonoBehaviour
{
    public GameManager_02 GM;
    
    public GameObject[] Moneys;

    public int MoneyType;

    int minNum = 0;
    int maxNum;

    
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager_02>();

        maxNum = Moneys.Length;

        SpawnOnce();
    }

    // Update is called once per frame
    void Update()
    {

        Stop();
    }

    IEnumerator Spawn()
    {

            while (true)
            {
                yield return new WaitForSeconds(GM.SpawnRate);

                MoneyType = Random.Range(minNum, maxNum);

                Instantiate(Moneys[MoneyType], transform.position, Quaternion.identity);
            }
        
        


    }

    void SpawnOnce()
    {
        Instantiate(Moneys[0], transform.position, Quaternion.identity);

        StartCoroutine(Spawn());
    }

    void Stop()
    {
        if(GM.IsDead == true)
        {
            StopAllCoroutines();
        }
    }
}
