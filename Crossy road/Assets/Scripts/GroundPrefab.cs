using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPrefab : MonoBehaviour
{
    public float limitZ = 10;

    void Update()
    {
        if(gameObject.transform.position.z <= -limitZ)
        {
            Destroy(gameObject);
        }
    }
}
