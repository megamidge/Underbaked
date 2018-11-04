using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject fallingBlockPrefab;

    public float secondsBetweenSpawns = 1f;
    float nextSpawnTime = 0f;

    public List<Ingredient> ingredients = new List<Ingredient>();

	// Use this for initialization
	void Start () {    
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondsBetweenSpawns;

            Vector3 spawnPosition = new Vector3(Random.Range(-4, 3), 10, Random.Range(-2.4f, 2.4f));

            GameObject go = new GameObject();
            go.AddComponent<IngredientObject>();
            go.GetComponent<IngredientObject>().ingredient = ingredients[Random.Range(0, ingredients.Count - 1)];
            go.AddComponent<FallingBlock>();
            go.AddComponent<Rigidbody>();
            go.AddComponent<BoxCollider>();

            GameObject Falling = Instantiate(go, new Vector3(spawnPosition.x, 30f, spawnPosition.z), Quaternion.identity);

            //Falling.GetComponent<FallingBlock>().ingredient = new Ingredient("Flour", 100);
        }
	}
}
