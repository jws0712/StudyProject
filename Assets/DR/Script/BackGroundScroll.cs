using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    public float Speed = 5f;
    public GameManager_02 GM;
    public Renderer BgRenderer;

    // Start is called before the first frame update
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
        BgRenderer.material.mainTextureOffset += new Vector2(Speed * Time.deltaTime, 0);
    }
}
