using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGMR : MonoBehaviour
{
    public bool isStop = false;

    private void Update()
    {
        if(isStop == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
                isStop = false;
            }
        }
    }
    public void StopButtonDown()
    {
        Time.timeScale = 0;
        isStop = true;
    }

    void ReStartClick()
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
