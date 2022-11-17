using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour
{
    public GameObject[] mapObjectPrefab;
    public GameObject carMaker;
    public GameObject ground;

    public float curTime;
    public float coolTime = 2;

    public float carSpeed = 5;

    public int mapLength;

    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 41; j++)
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
        MapMake();
    }

    void MapMake()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            int rnd = Random.Range(0, 100);
            if (rnd > 35)
            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 41; j++)
                    {
                        GameObject ground = Instantiate(mapObjectPrefab[0]);
                        ground.gameObject.name = ground.tag + $"({j}, {i})";
                        ground.transform.parent = GameObject.Find("Ground").transform;
                        ground.transform.localPosition = new Vector3(j, -1, i + mapLength);
                    }
                }
                mapLength++;
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 41; j++)
                    {
                        GameObject ground = Instantiate(mapObjectPrefab[1]);
                        ground.gameObject.name = ground.tag + $"({j}, {i})";
                        ground.transform.parent = GameObject.Find("Ground").transform;
                        ground.transform.localPosition = new Vector3(j, -1, i + mapLength);
                    }
                }
                mapLength++;
            }
        }
    }
}
