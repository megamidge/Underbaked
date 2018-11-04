using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingArea : MonoBehaviour {

    public List<IngredientObject> ingredientObjects;
    private bool CanPlace = false;
    private Collider Other = null;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        //If player is pressing key
        if (CanPlace)
        {
        if (Input.GetKey(KeyCode.E) )
        {
            Debug.Log("Interact");

            if(Other != null && Other.gameObject.GetComponentInChildren<Pot>().ingredient!=null)
            {
                ingredientObjects.Add(Other.gameObject.GetComponentInChildren<Pot>().ingredient);
                Other.gameObject.GetComponentInChildren<Pot>().ingredient = null;
            }
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Cook");
            //Cook item;
        }
    
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        if (other.tag == "Player")
        {
            Debug.Log("IsPlayer");
            CanPlace = true;
            Other = other;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        if(other.tag == "Player")
        {
            Debug.Log("IsPlayer");
            CanPlace = false;
           
        }
    }
}
