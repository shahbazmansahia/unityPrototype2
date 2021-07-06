using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private float topBound = 40.0f;
    private float bottomBound = -15.0f;
    private float leftBound = -25.0f;
    private float rightBound = 25.0f;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        // Destroys the object if it goes beyond the player's view
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }        
        else if (transform.position.z < bottomBound)
        {
            gameManager.changeLives(-1);
            //Debug.Log("Game 0ver!");
            Destroy(gameObject);
        }

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}
