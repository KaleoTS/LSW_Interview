using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject inventoryWindow;

    public void TurnOnOff()
    {
        inventoryWindow.SetActive(!inventoryWindow.activeSelf);
    }

}
