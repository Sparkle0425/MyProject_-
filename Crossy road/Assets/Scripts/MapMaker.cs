using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour
{
    public GameObject[] mapObjectPrefab;

    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                GameObject ground = Instantiate(mapObjectPrefab[0]);
                ground.gameObject.name = ground.tag + $"({j}, {i})";
                ground.transform.parent = GameObject.Find("Ground").transform;
                ground.transform.localPosition = new Vector3(j, -1, i);
            }
        }
    }

    void Update()
    {

    }
}
