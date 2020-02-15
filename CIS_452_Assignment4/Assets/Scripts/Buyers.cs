/*
     * (Levi Schoof)
     * (Buyers)
     * (Assignment 4)
     * (Handles the creation and managing of the customers and there stats)
     */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Buyers : MonoBehaviour
{
    public TextMeshProUGUI buyerPercantages;
    public TextMeshProUGUI pickText;
    [HideInInspector] public int royality;
    [HideInInspector] public int merchants;
    [HideInInspector] public int adventures;

    [HideInInspector] public int picky;

    private float percentageLeft = 100;

    private void Start()
    {
        royality = (int)Random.Range(0, percentageLeft - 40);
        percentageLeft -= royality;

        merchants = (int)Random.Range(0, percentageLeft);
        percentageLeft -= merchants;

        adventures = (int)percentageLeft;
        picky = (int)Random.Range(3, 5);
        SetText();
    }

    private void SetText()
    {
        buyerPercantages.text = "Number of Custoomers: 100 <br><br> Royality: " + royality + " (Want Beauty) <br> Merchants: " + merchants +
            " (Want CarryWeight) <br> Adventures: " + adventures + " (Want Damage)";

        pickText.text = "Minimum relative stat for buyers to purchase a monster<br> <b> " + picky + "</b>";
    }
}
