using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject ground;
    public GameObject coinPrefab;
    public GameObject carPrefab;

    public BoxCollider playercollider;

    public bool isDie = false;

    public GameObject gameOverText;

    public int CoinCut = 0;
    public Text coinCutText;

    public int scoreCut = 0;
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

            scoreCut++;
        }

        if(isDie ==true)
        {
            gameOverText.SetActive(true);
        }

        coinCutText.text = CoinCut + "";
        scoreText.text = scoreCut + "";
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
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1);
            ground.transform.position = new Vector3(ground.transform.position.x, 0, ground.transform.position.z + 1);
        }

        if (other.gameObject.tag == "Coin")
        {
            CoinCut++;
        }
    }
}
