using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Vector3 originpos;

    public float carSpeed = 5;
    public float limitX = 20;
  
    void Update()
    {
        RndSpeed();
        transform.Translate(carSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x > limitX)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z - 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z + 1);
        }
    }

    void RndSpeed()
    {
        int rnd = Random.Range(0, 100);
        if(rnd >= 35)
        {
            Random.Range(5, 10);
        }
        else
        {
            Random.Range(8, 13);
        }
    }
}
