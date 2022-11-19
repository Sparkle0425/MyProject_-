using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMaker : MonoBehaviour
{
    public GameObject ground;
    public GameObject coinPrefab;

    public float curTime;
    public float coolTime = 10;

    void Start()
    {
        
    }

    void Update()
    {
        curTime += Time.deltaTime;
        if(curTime >= coolTime)
        {
            ground = Instantiate(coinPrefab);
            coinPrefab.transform.position = new Vector3(Random.Range(-20, 20), 0, Random.Range(0, 20));
            curTime = 0;
        }
    }
}
