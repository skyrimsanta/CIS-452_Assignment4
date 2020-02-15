/*
     * (Levi Schoof)
     * (Goblin)
     * (Assignment 4)
     * (One of the Concrete Race Classes that Inhertnat from the base Monster class)
     */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Monster
{
    public Goblin()
    {
        this.description = "A Goblin";
    }
    public override int GetBeauty()
    {
        return 0;
    }

    public override int GetCarryWeight()
    {
        return 3;
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
        text.text = "A basic goblin: "  + "<br>" + "Damage: " + 0 + "<br>CarryWeight: " + 3 + "<br>Beauty: " + 0;
    }
}
