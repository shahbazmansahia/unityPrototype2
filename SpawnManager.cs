using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10.0f;
    private float spawnPosX = 15.0f;
    private float spawnRangeZ = 10.0f;
    private float spawnPosZ = 20.0f;
    private float zOffset = 13.5f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    public Quaternion spawnerRot;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void SpawnRandomAnimal()
    {
        // Picks the animal to spawn randomly. Format: Range (<min of range (inclusive)>, <max of range (exclusive)>)
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosHor = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        // Spawns animals at the top of the screen. Instantiate() format: (<object2Spawn>, <place2Spawn>, <rotation@Spawn>)
        Instantiate(animalPrefabs[animalIndex], spawnPosHor, animalPrefabs[animalIndex].transform.rotation);

        animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosVer = new Vector3(-spawnPosX, 0, Random.Range((-spawnRangeZ + zOffset), spawnRangeZ));
        // Rotates the spawner by an angle of 90 degrees from it's original position
        spawnerRot = animalPrefabs[animalIndex].transform.rotation;
        spawnerRot *= Quaternion.Euler(0, -90, 0);

        Instantiate(animalPrefabs[animalIndex], spawnPosVer, spawnerRot);

        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPosVer = new Vector3(spawnPosX, 0, Random.Range((-spawnRangeZ + zOffset), spawnRangeZ));
        // Rotates the spawner by an angle of 90 degrees from it's original position
        spawnerRot = animalPrefabs[animalIndex].transform.rotation;
        spawnerRot *= Quaternion.Euler(0, 90, 0);

        Instantiate(animalPrefabs[animalIndex], spawnPosVer, spawnerRot);
    }
}
