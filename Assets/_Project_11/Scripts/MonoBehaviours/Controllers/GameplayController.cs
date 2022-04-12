using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    [SerializeField] private CurrencyController currencyController;

    public void Init()
    {
        currencyController.Init();
    }
}