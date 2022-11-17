using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject)
        {
            Debug.Log(tag);
        }
    }
}
