using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private float topBound = 40.0f;
    private float bottomBound = -15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Debug.Log("Game 0ver!");
            Destroy(gameObject);
        }
    }
}
