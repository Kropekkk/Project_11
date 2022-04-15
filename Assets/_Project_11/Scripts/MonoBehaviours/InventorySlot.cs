using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InventorySlot : MonoBehaviour
{
    public int id;
    public int value;

    private UnityAction<int, int> onBuy;

    public void AddOnBuyListener(UnityAction<int, int> action)
    {
        onBuy = action;
    }
    
    public void Buy()
    {
        onBuy.Invoke(id, value);
    }
}