using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TUICON : MonoBehaviour
{
    public Button StartB;
    public Button QuitB;
    // Start is called before the first frame update
    void Start()
    {
        StartB.onClick.AddListener(StartBF);
        QuitB.onClick.AddListener(QuitBF);
    }

    void StartBF()
    {
        SceneManager.LoadScene("DinoRun");
    }

    void QuitBF()
    {
        Application.Quit();
    }
}
