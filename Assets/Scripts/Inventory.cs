// Class Inventory, holds the list of itens in the PLAYERS inventory, as well as methods to put and take from that list

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

// Declaration of this class as a Singleton
    #region Singleton                                   
    public static Inventory instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion 

    public delegate void OnItemChanged();               // Delegate to force an update on the list based on changes
    public OnItemChanged onItemChangedCallback;

    public List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);

        if(onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }
}
