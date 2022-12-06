using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public int CoinCut;

    public GameObject coinEffect;

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(coinEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
