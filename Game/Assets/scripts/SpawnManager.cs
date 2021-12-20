using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    public GameObject[] pickUpPrefabs;
    private float spawnRangeX = 10;
    private float spawnPosZ = -5;
    private float startDelay = 3;
    private float spawnInterval = 1f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, spawnInterval);
        InvokeRepeating("SpawnPickUps", startDelay, spawnInterval + 3f );
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnObstacles();
            SpawnPickUps();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {

        }
    }

    void SpawnObstacles()
    {
        int objectIndex = Random.Range(0, objectPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 13, spawnPosZ);
        Instantiate(objectPrefabs[objectIndex], spawnPos,
            objectPrefabs[objectIndex].transform.rotation);
    }

    void SpawnPickUps()
    {
        int pickUpIndex = Random.Range(0, pickUpPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 13, spawnPosZ);
        Instantiate(pickUpPrefabs[pickUpIndex], spawnPos,
            pickUpPrefabs[pickUpIndex].transform.rotation);
    }
}
