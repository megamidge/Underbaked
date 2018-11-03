using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    public FoodObject food;
    private GameObject go;
	// Use this for initialization
	void Start () {
        go = Instantiate(food.Mesh);
        go.transform.SetParent(this.gameObject.transform);
	}
	
}
