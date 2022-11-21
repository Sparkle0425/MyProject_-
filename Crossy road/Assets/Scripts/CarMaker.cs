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

    void Update()
    {
        MakeCar();
    }

    void MakeCar()
    {
        curTime += Time.deltaTime;
        if (curTime > coolTime)
        {
            GameObject car = Instantiate(carPrefab) as GameObject;
            car.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
            RndCoolTime();
            curTime = 0;
        }
    }

    void RndCoolTime()
    {
        coolTime = Random.Range(3, 7);
    }
}
