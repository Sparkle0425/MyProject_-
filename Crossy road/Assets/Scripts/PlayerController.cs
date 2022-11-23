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

    public BoxCollider playercollider;

    public bool isDie = false;

    public GameObject gameOverText;

    public int coinCut = 0;
    public Text coinCutText;

    int scoreCut = 0;
    public Text scoreText;

    void Start()
    {
        playercollider = GetComponent<BoxCollider>();
        coinCutText = GameObject.Find("CoinText").GetComponent<Text>();
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    void Update()
    {
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
            scoreCut ++;

            scoreCut = GMR.Instance().myScore;
            int myCurScore = GMR.Instance().myScore;
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
                SceneManager.LoadScene(0);
            }
        }

        scoreText.text = scoreCut + "";
        coinCutText.text = coinCut + "";
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
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (other.gameObject.tag == "Tree")
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
            }
        }


        if (other.gameObject.tag == "Coin")
        {
            coinCut++;
        }
    }
}
