using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivewayPrefab : MonoBehaviour
{
    public float limitZ = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, -1, transform.position.z - 1);
        }

        if (gameObject.transform.position.z <= -limitZ)
        {
            Destroy(gameObject);
        }
    }
}
