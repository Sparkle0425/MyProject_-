using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaker : MonoBehaviour
{
    public GameObject treePrefab;

    public GameObject coinPrefab;

    void Start()
    {
        int rnd = Random.Range(0, 100);
        if (rnd >= 90)
        {
            GameObject tree = Instantiate(treePrefab) as GameObject;
            tree.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
            tree.transform.parent = GameObject.Find("Object").transform;
        }

        if (rnd >= 95)
        {
            GameObject coin = Instantiate(treePrefab) as GameObject;
            coin.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
            coin.transform.parent = GameObject.Find("Object").transform;
        }
    }

    void Update()
    {

    }
}
