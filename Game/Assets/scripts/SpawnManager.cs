using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    public GameObject[] pickUpPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int objectIndex = Random.Range(0, objectPrefabs.Length);
            Instantiate(objectPrefabs[objectIndex], new Vector3(2, 13, -4),
                objectPrefabs[objectIndex].transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            int pickUpIndex = Random.Range(0, pickUpPrefabs.Length);
            Instantiate(pickUpPrefabs[pickUpIndex], new Vector3(2, 13, -4),
                pickUpPrefabs[pickUpIndex].transform.rotation);
        }
    }
}
