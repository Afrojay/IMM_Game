using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalInput;
    public float xRange = 10;

    public float turnRate = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * turnRate * Time.deltaTime * horizontalInput);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
       if (transform.position.z < -5)
        {
            transform.position = new Vector3(-5, transform.position.x, transform.position.y);
       }
        if (transform.position.z > -5)
       {
           transform.position = new Vector3(-5, transform.position.x, transform.position.y);
        }
    }
    //using this code we will allow the player to move left and right 
    void MovePlayer()
    {

    }
    //using this method we will keep the player in bounds
    void ConstrainPlayerPosition()
    {


    }
}
