using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UICon : MonoBehaviour
{
    public Button PlayButton;
    public Button ExitButton;

    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(OnPlayButton);
        ExitButton.onClick.AddListener(OnExitButton);
    }

    // Update is called once per frame
    void OnPlayButton() 
    {
        SceneManager.LoadScene("PTL");
    }

    void OnExitButton()
    {
        Application.Quit();
    }
}
