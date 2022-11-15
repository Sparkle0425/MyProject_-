using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMaker : MonoBehaviour
{
    public float curTime;
    public float coolTime = 2;

    public GameObject carPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        if (curTime > coolTime)
        {
            GameObject car = Instantiate(carPrefab) as GameObject;
            car.transform.position = new Vector3(-10, 0, 2);
            curTime = 0;
        }
    }
}
