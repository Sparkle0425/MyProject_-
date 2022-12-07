using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour
{
    public GameObject[] mapObjectPrefab;
    public GameObject carMaker;

    public int mapLength;

    public int startMap;

    void Start()
    {
        for (int i = 0; i < 60; i++)
        {
            if(i % 8 == 0 || i % 9 ==0)
            {
                for (int j = 0; j < 1; j++)
                {
                    GameObject ground = Instantiate(mapObjectPrefab[1]);
                    ground.gameObject.name = ground.tag + $"({j}, {i})";
                    ground.transform.parent = GameObject.Find("Ground").transform;
                    ground.transform.localPosition = new Vector3(-j, -1, i);
                }
            }
            else
            {
                for (int j = 0; j < 1; j++)
                {
                    GameObject ground = Instantiate(mapObjectPrefab[0]);
                    ground.gameObject.name = ground.tag + $"({j}, {i})";
                    ground.transform.parent = GameObject.Find("Ground").transform;
                    ground.transform.localPosition = new Vector3(-j, -1, i);
                }
            }
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            int rnd = Random.Range(0, 100);
            if(rnd >= 40)
            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        GameObject ground = Instantiate(mapObjectPrefab[0]);
                        ground.gameObject.name = ground.tag + $"({j}, {i})";
                        ground.transform.parent = GameObject.Find("Ground").transform;
                        ground.transform.localPosition = new Vector3(-j, -1, i + mapLength);
                    }
                }
                mapLength++;
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        GameObject ground = Instantiate(mapObjectPrefab[1]);
                        ground.gameObject.name = ground.tag + $"({j}, {i})";
                        ground.transform.parent = GameObject.Find("Ground").transform;
                        ground.transform.localPosition = new Vector3(-j, -1, i + mapLength);
                    }
                }
                mapLength++;
            }
        }
    }
}
