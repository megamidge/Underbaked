using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject fallingBlockPrefab;

    public float secondsBetweenSpawns = 1f;
    float nextSpawnTime = 0f;
 
    Vector3 screenHalfSizeWorldUnits;

	// Use this for initialization
	void Start () {
        screenHalfSizeWorldUnits = new Vector3(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondsBetweenSpawns;

            Vector3 spawnPosition = new Vector3(Random.Range(-4, 3), 10, Random.Range(-2.25f, 3));
            Instantiate(fallingBlockPrefab, spawnPosition, Quaternion.identity);
        }
	}
}
