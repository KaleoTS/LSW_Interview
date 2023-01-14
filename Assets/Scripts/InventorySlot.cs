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

    public GameObject player;

    private void Start()
    {
        CleanSlot();
        player = GameObject.Find("Player");
    }
    public void AddItem(Item n_item)
    {
        item = n_item;

        itemIcon.sprite = item.iconItem;
        itemIcon.enabled = true;
        value.text = item.value.ToString();
        itemname.text = item.name;

    }

    public void CleanSlot()
    {
        item = null;

        itemIcon.sprite = null;
        itemIcon.enabled= false;
        value.text = "";
        itemname.text = "";
    }

    public void SellItem()
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
