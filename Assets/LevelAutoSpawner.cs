using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAutoSpawner : MonoBehaviour
{
    public GameObject[] objects;


    private void Start()
    {
        int rand =Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
    }

    /*public GameObject[] animalPrefabs;
    private float startDelay = 0.1f;
    private float spawnInterval = 0.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    private float spawnRangeX = -20;
    private float spawnPosY = -20;
    void Update() 
    {

    }
    
    void SpawnRandomAnimal() 
    {
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(25, 290), spawnPosY);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation); 
    }*/
}