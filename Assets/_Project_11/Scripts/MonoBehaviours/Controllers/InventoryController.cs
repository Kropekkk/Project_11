using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InventoryController : MonoBehaviour
{
    public List<InventorySlot> inventorySlots = new List<InventorySlot>();

    private void Start()
    {
        Init();
    }

    public void Init()
    {

    }
}