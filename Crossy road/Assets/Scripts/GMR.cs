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
            _myScore = value;
            if (_myScore > _bestScore)
            {
                _bestScore = _myScore;
                SaveBestScore();
            }
        }
    }
    void SaveBestScore()
    {
        PlayerPrefs.SetInt("BestScore", _bestScore);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
