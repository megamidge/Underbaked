using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IngredientObject", menuName = "Ingredient")]
public class Ingredient : ScriptableObject
{
    public string ItemName;
    public GameObject obj;
    public int Points;
}
