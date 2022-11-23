using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaker : MonoBehaviour
{
    public GameObject treePrefab;

    public GameObject coinPrefab;

    void Start()
    {
        int rnd = Random.Range(0, 3);
        if(rnd == 0)
        {
            int rud = Random.Range(0, 100);
            if (rud >= 90)
            {
                GameObject tree = Instantiate(treePrefab) as GameObject;
                tree.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
                tree.transform.parent = GameObject.Find("Object").transform;
                if(tree.transform.position == coinPrefab.transform.position)
                {
                    Destroy(tree);
                }
            }
        }
        else if(rnd == 1)
        {
            int rud = Random.Range(0, 100);
            if (rud >= 90)
            {
                GameObject tree = Instantiate(treePrefab) as GameObject;
                tree.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
                tree.transform.parent = GameObject.Find("Object").transform;
                if (tree.transform.position == coinPrefab.transform.position)
                {
                    Destroy(tree);
                }
            }
        }
        else
        {
            int rud = Random.Range(0, 100);
            if (rud >= 95)
            {
                GameObject coin = Instantiate(treePrefab) as GameObject;
                coin.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
                coin.transform.parent = GameObject.Find("Object").transform;
            }
        }
    }
}
