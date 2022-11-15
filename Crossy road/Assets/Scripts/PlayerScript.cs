using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int coinCnt = 0;
    public float playerSpeed;

    public GameObject coinPrefab;

    void Start()
    {
    
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 1);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coinCnt++;
            Destroy(coinPrefab);
        }
    }
}
