
/*
     * (Levi Schoof)
     * (Monster)
     * (Assignment 4)
     * (The base class that the Concrete classes and observers will derive from)
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Monster : MonoBehaviour
{
    [HideInInspector] public string description;
    public int price;


    [HideInInspector] public int damage;
    [HideInInspector] public int beauty;
    [HideInInspector] public int carryWeight;
    [HideInInspector] public int cost;

    public GameObject panel;
    public TextMeshProUGUI text;

    public virtual string GetDescription()
    {
        return description;
    }

    public abstract int GetBeauty();
    public abstract int GetDamage();
    public abstract int GetCarryWeight();
    public abstract int GetCost();

    public abstract void PanelText();
    public void TurnOffPanel()
    {
        panel.SetActive(false);
    }

    private void Start()
    {
        TurnOffPanel();
    }
}
