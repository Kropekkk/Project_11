using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyController : MonoBehaviour
{
    public static CurrencyController instance;

    [SerializeField] private TextMeshProUGUI currencyValueT;
    
    public int currency;

    public void Init()
    {
        instance = this;
        currency = PlayerPrefs.GetInt("MyCurrency");
        currency = 1000;
        currencyValueT.text = "" + currency;
    }

    public void Set()
    {
        currencyValueT.text = "" + currency;
    }

    public void Save()
    {
        PlayerPrefs.SetInt("MyCurrency", currency);
    }
}