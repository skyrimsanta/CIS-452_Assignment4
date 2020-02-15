/*
     * (Levi Schoof)
     * (Siren)
     * (Assignment 4)
     * (One of the Concrete Race Classes that Inhertnat from the base Monster class)
     */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siren : Monster
{
    public Siren()
    {
        this.description = "A Siren";
    }
    public override int GetBeauty()
    {
        return 3;
    }

    public override int GetCarryWeight()
    {
        return 0;
    }

    public override int GetCost()
    {
        return 0;
    }

    public override int GetDamage()
    {
        return 0;
    }

    public override void PanelText()
    {
        panel.SetActive(true);
        text.text = "A Siren " + "<br>Damage: " + 0 + "<br>CarryWeight: " + 0 + "<br>Beauty: " + 3;
    }
}
