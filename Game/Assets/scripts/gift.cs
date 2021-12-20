using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gift : MonoBehaviour
{
    public int collisionCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void CountColisions(Collider other)
    {
        ScoreKeep.score += 100;
        Debug.Log("HO! Ho! Ho!");
    }
}
