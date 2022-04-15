using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public List<InventorySlot> inventorySlots = new List<InventorySlot>();

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        foreach(InventorySlot inventorySlot in inventorySlots)
        {
            inventorySlot.AddOnBuyListener(OnBuyEvent);
        }
    }

    private void OnBuyEvent(int id, int value)
    {
        DefenderSpawner.instance.Spawn(id);
        CurrencyController.instance.currency -= value;
        CurrencyController.instance.Set();
    }
}