using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject ground;
    public GameObject coinPrefab;
    public GameObject carPrefab;

    public BoxCollider playercollider;

    void Start()
    {
        playercollider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x + 1, 0, ground.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x - 1, 0, ground.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x, 0, ground.transform.position.z - 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ground.transform.position = new Vector3(ground.transform.position.x, 0, ground.transform.position.z + 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    { 
        if(other.gameObject.tag == "Car")
        {
            playercollider.size = new Vector3(0, 0, 0);
        }
    }
}
