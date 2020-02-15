/*
     * (Levi Schoof)
     * (Skeleton)
     * (Assignment 4)
     * (One of the Concrete Race Classes that Inhernts from the base Monster class)
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Monster
{

    public Skeleton()
    {
        this.description = "A Skeleton";
    }
    public override int GetBeauty()
    {
        return 0;
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
        return 3;
    }

    public override void PanelText()
    {
        panel.SetActive(true);
        text.text = "A Skeleton: "  + "<br>Damage: " + 3 + "<br>CarryWeight: " + 0 + "<br>Beauty: " + 0;
    }
}
