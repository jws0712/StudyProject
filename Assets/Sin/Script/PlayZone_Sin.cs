using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayZone_Sin : MonoBehaviour
{

    public Player_Sin Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Player.IsBullet = false;
    }
}
