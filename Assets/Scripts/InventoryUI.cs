// Class InventoryUI
// Controls the UI for the player inventory. Contain methods to update it;
// Contains and controls the array of slots used as base for the inventory system.


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    Inventory inventory;
    public InventorySlot[] slots;

    public Transform inventoryContent;
    public GameObject inventorySlot;

    public void TurnOnOff()                                                     //Method used to turn the UI ON and OFF
    {
        GameObject.Find("InventoryUI").SetActive(!gameObject.activeSelf);
    }

    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateInventory;
        slots = inventoryContent.GetComponentsInChildren<InventorySlot>(true);

    }

    // Update is called once per frame
    void Update()
    {
        UpdateInventory();
    }
    
    public void UpdateInventory()                           //Method used to update the Array of slots with the itens on the Inventory List.
    {         
        for(int i = 0 ; i < slots.Length; i++)
        {
            if(i < inventory.items.Count)
            {

                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].CleanSlot();
            }
        }

    }
}
