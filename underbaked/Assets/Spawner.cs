using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject fallingBlockPrefab;

    public float secondsBetweenSpawns = 1f;
    float nextSpawnTime = 0f;
 
	// Use this for initialization
	void Start () {    
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondsBetweenSpawns;

            Vector3 spawnPosition = new Vector3(Random.Range(-4, 3), 10, Random.Range(-2.4f, 2.4f));
            GameObject Falling = Instantiate(fallingBlockPrefab, spawnPosition, Quaternion.identity);

            //Falling.GetComponent<FallingBlock>().ingredient = new Ingredient("Flour", 100);
        }
	}
}
