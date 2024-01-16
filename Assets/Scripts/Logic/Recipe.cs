// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// using System;
// using UnityEngine;

// public class Recipe : MonoBehaviour
// {
//     public Item[] items;
//     public float totalPrice;
// }



using System;
using UnityEngine;

public enum IngredientUnit { Spoon, Cup, Bowl, Piece }

// Custom serializable class
[Serializable]
public class Ingredient
{
    public string name;
    public int amount = 1;
    public IngredientUnit unit;
}

public class Recipe : MonoBehaviour
{
    public Ingredient potionResult;
    public Ingredient[] potionIngredients;
}