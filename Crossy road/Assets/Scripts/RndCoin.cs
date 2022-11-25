using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RndCoin : MonoBehaviour
{
    public GameObject[] objectMake;
    public GameObject coinMaker;

    void Start()
    {
        int rnd = Random.Range(0, objectMake.Length);
        coinMaker.SetActive(true);
    }
}
