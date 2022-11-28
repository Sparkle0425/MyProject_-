using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject ground;
    public GameObject coinPrefab;
    public GameObject carPrefab;
    public GameObject objectPtrfab;

    public float speed = 0;
    public float power = 0;

    public BoxCollider playercollider;

    public bool isDie = false;

    public GameObject gameOverText;

    int _coinCut = 0;
    public Text coinCutText;

    public Text scoreText;

    public UIGMR isStop;
    void Start()
    {
        playercollider = GetComponent<BoxCollider>();
        LoadCoinScore();
    }

    public  int coinScore
    {
        get
        {
            return _coinCut;
        }
        set
        {
            SaveCoinScore();
        }
    }

    void Update()
    {
        int myCurScore = GMR.Instance().myScore;
        int myBestScore = GMR.Instance().bestScore;

        scoreText.text = myCurScore + "\n" + myBestScore;

        coinScore = _coinCut;
        coinCutText.text = coinScore + "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x + 1, 0, ground.transform.position.z);

            if (ground.transform.position.x >= 10)
            {
                ground.transform.position = new Vector3(10, 0, ground.transform.position.z);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x - 1, 0, ground.transform.position.z);

            if (ground.transform.position.x <= -10)
            {
                ground.transform.position = new Vector3(-10, 0, ground.transform.position.z);
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x, 0, ground.transform.position.z - 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x, 0, ground.transform.position.z + 1);
        }

        if (isDie ==true)
        {
            gameOverText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.DownArrow))
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    void SaveCoinScore()
    {
        PlayerPrefs.SetInt("CoinScore", _coinCut);
    }

    void LoadCoinScore()
    {
        _coinCut = PlayerPrefs.GetInt("CoinScore");
    }

    private void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.tag == "Car")
        {
            playercollider.size = new Vector3(0, 0, 0);
            isDie = true;
        }

        if (other.gameObject.tag == "Tree")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1);
                ground.transform.position = new Vector3(ground.transform.position.x, ground.transform.position.y, ground.transform.position.z);
                carPrefab.transform.position = new Vector3(carPrefab.transform.position.x, carPrefab.transform.position.y, carPrefab.transform.position.z + 1);
                coinPrefab.transform.position = new Vector3(coinPrefab.transform.position.x, coinPrefab.transform.position.y, coinPrefab.transform.position.z + 1);
                objectPtrfab.transform.position = new Vector3(objectPtrfab.transform.position.x, objectPtrfab.transform.position.y, objectPtrfab.transform.position.z + 1);
            }
        }
        if (other.gameObject.tag == "Tree")
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1);
                ground.transform.position = new Vector3(ground.transform.position.x, ground.transform.position.y, ground.transform.position.z - 1);
                carPrefab.transform.position = new Vector3(carPrefab.transform.position.x, carPrefab.transform.position.y, carPrefab.transform.position.z - 1);
                coinPrefab.transform.position = new Vector3(coinPrefab.transform.position.x, coinPrefab.transform.position.y, coinPrefab.transform.position.z - 1);
                objectPtrfab.transform.position = new Vector3(objectPtrfab.transform.position.x, objectPtrfab.transform.position.y, objectPtrfab.transform.position.z - 1);
            }
        }
        if (other.gameObject.tag == "Tree")
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
            }
        }
        if (other.gameObject.tag == "Tree")
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);

            }
        }

        if (other.gameObject.tag == "Coin")
        {
            _coinCut++;
        }
    }
}
