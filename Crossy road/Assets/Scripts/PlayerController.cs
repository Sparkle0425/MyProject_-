using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    RaycastHit hit2;

    public int coinCnt = 0;

    public GameObject coinPrefab;
    public GameObject carPrefab;
    public GameObject gameOverText;

    public BoxCollider playercollider;

    public Text coinCntText;

    public Transform playerCharacter;

    void Start()
    {
        playercollider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CheckOthers(Vector3.left);
            //playerCharacter.localRotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CheckOthers(Vector3.right);
            //playerCharacter.localRotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckOthers(Vector3.forward);
            //playerCharacter.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CheckOthers(Vector3.back);
            //playerCharacter.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }

    public void CheckOthers(Vector3 dir)
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(dir), out hit, 1.0f))
        {
            Transform tr = hit.collider.transform;
            Debug.Log(hit.collider.gameObject.tag);
            switch (hit.collider.tag)
            {
                case "Tree":
                    Debug.Log("그건 나무야!!");
                    break;
                case "Rock":
                    Debug.Log("그쪽은 돌이야!!");
                    break;
                case "Coin":
                    coinCnt++;
                    Destroy(coinPrefab);
                    transform.Translate(dir);
                    break;
                case "Car":
                    playercollider.size = new Vector3(0, 0, 0);
                    break;
                default:
                    break;
            }
        }
        else
        {
            transform.Translate(dir);
        }
    }
}
