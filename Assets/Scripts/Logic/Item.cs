using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public enum ItemType 
{ 
    Material,
    Equip,
    Alchemist,
    Usual,
}

public enum ItemUnit 
{
    Spoon, 
    Cup, 
    Bowl, 
    Piece, 
    mg, 
    g, 
    kg, 
    l, 
    ml, 
}


// Custom serializable class
[Serializable]
public class Item
{
    public string name;
    public Texture2D texture;
    public ItemType type;
    public int amount = 1;
    public ItemUnit unit;
    public float price;
}
