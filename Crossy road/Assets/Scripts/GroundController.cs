using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public float speed = 0;
    public float power = 0;
    public Vector3 startPos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Debug.Log(Input.mousePosition);
            startPos = Input.mousePosition;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Vector2 endPds = Input.mousePosition;
            float swipeLength = endPds.x - startPos.x;
            if (swipeLength >= 1)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, 0, gameObject.transform.position.z);
            }
        }
    }
}
