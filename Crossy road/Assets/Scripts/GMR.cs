using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMR : MonoBehaviour
{
    static GMR _instance = null;

    public static GMR Instance()
    {
        return _instance;
    }

    private void Awake()
    {
        if (_instance == null)
            _instance = this;

        LoadBestScore();
    }

    int _bestScore = 0;
    int _myScore = 0;

    public int bestScore
    {
        get
        {
            return _bestScore;
        }
    }

    public int myScore
    {
        get
        {
            return _myScore;
        }
        set
        {
            if (_myScore >= _bestScore)
            {
                _bestScore = _myScore;
                SaveBestScore();
            }
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            _myScore++;
        }
        myScore = _myScore;
    }

    void SaveBestScore()
    {
        PlayerPrefs.SetInt("BestScore", _bestScore);
    }

    void LoadBestScore()
    {
        _bestScore = PlayerPrefs.GetInt("BestScore");
    }
}
