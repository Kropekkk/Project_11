using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currencyValueT;
    
    private int currency;

    public void Init()
    {
        currency = PlayerPrefs.GetInt("MyCurrency");
        currencyValueT.text = "" + currency;
    }

    public void Save()
    {
        PlayerPrefs.SetInt("MyCurrency", currency);
    }
}