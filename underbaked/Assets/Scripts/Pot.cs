using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour {

    public List<IngredientObject> ingredients = new List<IngredientObject>();
    public IngredientObject ingredient;
    public GameManager gm;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ingredient")
        {
            gm.Points += 1;
            //ingredients.Add(other.gameObject.GetComponent<FallingBlock>().ingredient);
            //ingredients.Add(other.gameObject.GetComponent<FallingBlock>().ingredient);
            ingredient = other.gameObject.GetComponent<IngredientObject>();
            Destroy(other.gameObject);
            //Debug.Log(ingredients.Count + " " + ingredients[ingredients.Count - 1]);
        }
    }
}
