using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> objects;
    private float spawnRate = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnObject()
    {
        yield return new WaitForSeconds(spawnRate);
        int index = Random.Range(0, objects.Count);
        Instantiate(objects[index]);
    }
}
