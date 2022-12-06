using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPrefab : MonoBehaviour
{
    public float limitZ = 10;
    public GameObject[] groundPrefab;

    private void Start()
    {
        int rnd = Random.Range(0, 2);
        if(rnd == 0)
        {
            groundPrefab[0].SetActive(true);
        }
        else
        {
            groundPrefab[1].SetActive(true);
        }
    }

    void Update()
    {
        if (gameObject.transform.position.z <= -limitZ)
        {
            Destroy(gameObject);
        }
    }
}
