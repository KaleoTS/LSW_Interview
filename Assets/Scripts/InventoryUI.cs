using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    Inventory inventory;
    InventorySlot[] slots;

    public Transform inventoryContent;

    public void TurnOnOff()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateInventory;

        slots = inventoryContent.GetComponentsInChildren<InventorySlot>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateInventory()
    {
        for(int i = 0 ; i < slots.Length; i++)
        {

        }

    }
}
