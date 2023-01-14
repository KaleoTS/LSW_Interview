// ShopUI class
// Does the same as the InventoryUI class, but controls the Shop UI.


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    ShopController shop;
    public InventorySlot[] slots;

    public Transform shopContent;
    public GameObject inventorySlot;

    void Start()
    {
        shop = ShopController.instance;
        shop.onItemChangedShopCallback += UpdateInventory;
        slots = shopContent.GetComponentsInChildren<InventorySlot>(true);

    }

    // Update is called once per frame
    void Update()
    {
        UpdateInventory();
    }

    public void UpdateInventory()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < shop.items.Count)
            {
                slots[i].AddItem(shop.items[i]);
            }
            else
            {
                slots[i].CleanSlot();
            }
        }

    }
}
