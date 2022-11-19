using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject ground;
    public GameObject coinPrefab;
    public GameObject carPrefab;
    public GameObject treePrefab;

    public BoxCollider playercollider;

    public bool isDie = false;

    void Start()
    {
        playercollider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x + 1, 0, ground.transform.position.z);

            if (ground.transform.position.x >= 10)
            {
                ground.transform.position = new Vector3(10, 0, ground.transform.position.z);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x - 1, 0, ground.transform.position.z);

            if (ground.transform.position.x <= -10)
            {
                ground.transform.position = new Vector3(-10, 0, ground.transform.position.z);
            }

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x, 0, ground.transform.position.z - 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z - 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.tag == "Car")
        {
            playercollider.size = new Vector3(0, 0, 0);
            isDie = true;
        }

        if (other.gameObject.tag == "Tree")
        {
            Debug.Log(gameObject.tag);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z + 1);
        }
    }
}
