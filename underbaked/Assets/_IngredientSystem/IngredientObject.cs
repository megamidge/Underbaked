using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientObject : MonoBehaviour {

    public Ingredient ingredient;
    private GameObject go;

	void Start () {
        go = Instantiate(ingredient.obj);
        go.transform.SetParent(this.gameObject.transform);
	}
}
