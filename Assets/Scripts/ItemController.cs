// ItemController class
// Implements the methods that allows itens to be picked and added to the inventory.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public Item item;

    public void PickItemUp()
    {
        Inventory.instance.AddItem(item);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        PickItemUp();
        //Debug.Log("Clicked");
    }
}
