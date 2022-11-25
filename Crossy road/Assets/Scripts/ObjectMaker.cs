using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaker : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject coinPrefab;

    void Start()
    {
        
            int rud = Random.Range(0, 100);
            if (rud >= 95)
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
}
