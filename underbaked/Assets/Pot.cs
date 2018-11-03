using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __Ingredient
{
    string ItemName;
    int Points;

    __Ingredient(string pItemName, int pPoints)
    {
        ItemName = pItemName;
        Points = pPoints;
    }
}

public class Pot : MonoBehaviour {

    public List<GameObject> ingredients = new List<GameObject>();

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
            ingredients.Add(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
