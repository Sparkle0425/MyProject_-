using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerNo : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        Physics2D.IgnoreLayerCollision(6, 7);
    }
}
