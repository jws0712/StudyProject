using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int PlayerSocre = 0;
    public Text ScoreText;
    public GameObject gameOverScreen;

    public bool OnStick = false;
    public bool AttackBall = false;
    public bool IsBall = false;
    public bool IsDead = false;

    public void AddScore()
    {
        PlayerSocre += 1;
        ScoreText.text = PlayerSocre.ToString();
    }

    public void ReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        IsDead = true;
    }
}
