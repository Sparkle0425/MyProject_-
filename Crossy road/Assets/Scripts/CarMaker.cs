using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMaker : MonoBehaviour
{
    public float curTime;
    public float coolTime = 2;

    public float carSpeed = 5;

    public GameObject carPrefab;
    public GameObject ground;
    void Start()
    {
        
    }

    void Update()
    {
        curTime += Time.deltaTime;
        if (curTime > coolTime)
        {
            GameObject car = Instantiate(carPrefab) as GameObject;
            car.transform.position = new Vector3(ground.transform.position.x, 0, ground.transform.position.z);
            curTime = 0;
        }
    }
}
