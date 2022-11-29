using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public int CoinCut;

    public Vector3 startPos;

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

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
