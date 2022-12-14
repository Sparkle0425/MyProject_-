using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMaker : MonoBehaviour
{
    public GameObject[] objectMake;
    public GameObject coinPrefab;

    void Start()
    {
        RandomPosition();
        int rud = Random.Range(0, 100);
        if (rud <= 1)
        {
            GameObject coin = Instantiate(coinPrefab) as GameObject;
            coin.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
            coin.transform.parent = GameObject.Find("Object").transform;
        }
    }

    void RandomPosition()
    {
        int rnd = Random.Range(0, objectMake.Length);
    }
}
