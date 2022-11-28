using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPrefab : MonoBehaviour
{
    public float limitZ = 10;

    public Vector3 startPos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            startPos = Input.mousePosition;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Vector2 endPds = Input.mousePosition;
            float swipeLengthX = endPds.x - startPos.x;
            if (swipeLengthX >= 1)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.25f, -1, gameObject.transform.position.z - 1);
            }
            else
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.25f, -1, gameObject.transform.position.z);
            }
            float swipeLengthY = endPds.y - startPos.y;
            if(swipeLengthY >= 1)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, -1, gameObject.transform.position.z + 1);
            }
        }

        if (gameObject.transform.position.z <= -limitZ)
        {
            Destroy(gameObject);
        }
    }
}
