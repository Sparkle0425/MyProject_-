using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float carSpeed = 5;
    public float limitX = 20;

    private void Start()
    {
        RndSpeed();
    }

    void Update()
    {
        transform.Translate(carSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x > limitX)
        {
            Destroy(gameObject);
        }
    }

    void RndSpeed()
    {
        int rnd = Random.Range(5,20);
        carSpeed = rnd;
    }
}
