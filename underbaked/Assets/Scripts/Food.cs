using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName="FoodObject",menuName="IngredientSystem/Food Object")]
public class FoodObject : ScriptableObject {
    public string Name;
    public List<Ingredient> Ingredients;
    public GameObject Mesh;    
}
