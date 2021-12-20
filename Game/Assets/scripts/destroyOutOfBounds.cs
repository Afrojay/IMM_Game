using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyOutOfBounds : MonoBehaviour
{
    private float bottomBound = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomBound)
        {
           ScoreKeep.score += 10;
            Destroy(gameObject);
            
        }
    }
}
