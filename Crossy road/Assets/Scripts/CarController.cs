using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Vector3 originpos;

    public float carSpeed;
    public float limitX;
    public float curTime;
    public float coolTime = 2;

    void Start()
    {
        
    }

    void Update()
    {
        curTime += Time.deltaTime;
        if(curTime > coolTime)
        {
            Instantiate(gameObject);
            curTime = 0;
        }

        transform.Translate(carSpeed * Time.deltaTime, 0, 0);
        if (transform.position.x > limitX)
        {
            Destroy(gameObject);
        }
    }
}
