using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    #region Singleton
    public static ShopController instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion 

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }
}
