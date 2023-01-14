//Class to define the the itens as Scriptable Objects

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public int value = 10;
    public Sprite iconItem = null;
}
