// Class InventorySlot
// Defines the methods and variables of the slots in the inventory, both for the player and the shop


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item item;

    public Image itemIcon;
    public TextMeshProUGUI value;
    public TextMeshProUGUI itemname;

    public GameObject player;                               // Cached a reference for the player, too make it easy to access its variables.

    private void Start()
    {
        CleanSlot();
        player = GameObject.Find("Player");
    }
    public void AddItem(Item n_item)                        // method to add an item to the Slot
    {
        item = n_item;

        itemIcon.sprite = item.iconItem;
        itemIcon.enabled = true;
        value.text = item.value.ToString();
        itemname.text = item.name;

    }

    public void CleanSlot()                                 // Method to clear a slot       
    {
        item = null;

        itemIcon.sprite = null;
        itemIcon.enabled= false;
        value.text = "";
        itemname.text = "";
    }

    public void SellItem()                                  // method to sell itens, both from the player > shop as well as shop > player
    {
        if (this.CompareTag("NPC"))
        {
            //CleanSlot();
            if (player.GetComponent<PlayerController>().enableShopping)
            {
                Inventory.instance.AddItem(item);
                ShopController.instance.RemoveItem(item);

                player.GetComponent<PlayerController>().BuyItem(item);
            }

        }

        if (this.CompareTag("Player"))
        {
            if (player.GetComponent<PlayerController>().enableShopping)
            {
                ShopController.instance.AddItem(item);
                Inventory.instance.RemoveItem(item);

                player.GetComponent<PlayerController>().SellItem(item);
            }

        }
    }
}
