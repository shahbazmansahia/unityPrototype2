using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SahilController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float velocity = 10.0f;
    // to determine the range which the Sahil (player) can travel
    private float xRange = 10.0f;
    private float zRange = 15.0f;
    private float zOffset = 13.5f;
    // The projectile that the player will throw
    public GameObject projectilePrefab;
    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < (-zRange + zOffset))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, (-zRange + zOffset));
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * velocity);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * velocity);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launches a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
