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

    public void TurnOnOff()
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
    
    public void UpdateInventory()
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
