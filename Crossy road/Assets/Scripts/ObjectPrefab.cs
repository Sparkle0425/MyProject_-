using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPrefab : MonoBehaviour
{
    public float limitZ = 10;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, 0, gameObject.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1, 0, gameObject.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z - 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z + 1);
        }

        if (gameObject.transform.position.z <= -limitZ)
        {
            Destroy(gameObject);
        }
    }
}
