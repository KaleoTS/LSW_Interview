using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    Item item;

    public Image itemIcon;

    public void AddItem(Item n_item)
    {
        item = n_item;

        itemIcon.sprite = item.iconItem;
        itemIcon.enabled = true;
    }

    public void CleanSlot()
    {
        item = null;

        itemIcon.sprite = null;
        itemIcon.enabled= false;
    }
}
