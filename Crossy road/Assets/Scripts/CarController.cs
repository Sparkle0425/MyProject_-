using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Vector3 originpos;

    public float carSpeed = 5;
    public float limitX;
  
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(carSpeed * Time.deltaTime, 0, 0);
        if (transform.position.x > limitX)
        {
            Destroy(gameObject);
        }
        RndCarSpeed();
    }

    void RndCarSpeed()
    {
        carSpeed = Random.Range(5, 10);
    }
}
