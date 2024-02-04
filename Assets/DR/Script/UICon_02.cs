using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UICon_02 : MonoBehaviour
{
    public GameManager_02 GM;
    public Text Text;
    public Text BestScroe;
    public float BestSc = 0;

    private float Score = 0;
    public float FinScore = 0;
    public GameObject GameOverScreen;
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
            GameOverScreen.SetActive(true);


        }
        else
        {
            Score += Time.deltaTime;
            FinScore = Mathf.Floor(Score);
            Text.text = FinScore.ToString();

            BestSc = PlayerPrefs.GetFloat("Best Socre", 0);

            BestScroe.text = BestSc.ToString();
        }


        
    }

    public void REstartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
