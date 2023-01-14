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


    private void Start()
    {
        CleanSlot();
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
}
