using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGMR : MonoBehaviour
{
    public GameObject stopButton;

    public bool isStop = false;

    public void StopButtonDown()
    {
        Time.timeScale = 0;
        isStop = true;
        stopButton.SetActive(false);
    }

    public void ReStartButtonClick()
    {
        Time.timeScale = 1;
        isStop = false;
    }

    public void ReStartClick()
    {
        SceneManager.LoadScene(0);
    }

    public void PopUpPanelOnoff(bool onOff)
    {
        if (onOff)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void ExitButtonClick()
    {
        Application.Quit();
    }

    public void StartButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
