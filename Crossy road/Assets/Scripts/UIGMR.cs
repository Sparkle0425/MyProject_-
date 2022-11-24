using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGMR : MonoBehaviour
{
    public void StopButtonDown()
    {
        Time.timeScale = 0;
    }

    void ReStartClick()
    {
        SceneManager.LoadScene(0);
    }
}
