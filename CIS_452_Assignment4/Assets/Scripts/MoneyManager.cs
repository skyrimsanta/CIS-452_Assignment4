/*
     * (Levi Schoof)
     * (MoneyManager)
     * (Assignment 4)
     * (Handles and manages the currency)
     */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    private int moneyLeft;
    private int startingMoney = 3;
    // Start is called before the first frame update
    void Start()
    {
        moneyLeft = startingMoney;
        UpdateText();
    }

    public void NewMonster()
    {
        moneyLeft = startingMoney;
        UpdateText();
    }

    public void MadePurchase(Monster money)
    {
        moneyLeft = startingMoney - money.GetCost();
        UpdateText();
    } 

    private void UpdateText()
    {
        moneyText.text = "Remaininng Money: " + moneyLeft;
    }

    public int GetRemainingMoney()
    {
        return moneyLeft;
    }
}
