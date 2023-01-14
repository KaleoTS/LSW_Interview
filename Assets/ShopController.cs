// ShopController Class
// Does the same as the Inventory Class, but for the Shop.


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

    public delegate void OnItemChangedShop();
    public OnItemChangedShop onItemChangedShopCallback;

    public List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);

        if (onItemChangedShopCallback != null)
        {
            onItemChangedShopCallback.Invoke();
        }
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }
}
