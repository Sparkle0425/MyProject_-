using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour
{
    public GameObject[] mapObjectPrefab;
    public GameObject carMaker;


    public float curTime;
    public float coolTime = 2;

    public float carSpeed = 5;

    public int mapLength;

    public int mapLength;

    void Start()
    {
        for (int i = 0; i < 40; i++)
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

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            for (int i = 0; i < mapLength; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    GameObject ground = Instantiate(mapObjectPrefab[0]);
                    ground.gameObject.name = ground.tag + $"({j}, {i})";
                    ground.transform.parent = GameObject.Find("Ground").transform;
                    ground.transform.localPosition = new Vector3(j, -1, i+40);
                }
            }
            mapLength++;
        }
    }
}
