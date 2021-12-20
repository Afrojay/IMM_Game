using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //once a collision happens between a falling obstacle and the player the game ends
    private void OnTriggerEnter(Collider other)
    {
        GameOver.gameOverText.gameObject.SetActive(true);
        Debug.Log("Game Over!");
        // Destroy(gameObject);
        Destroy(other.gameObject);
       
    }


}
