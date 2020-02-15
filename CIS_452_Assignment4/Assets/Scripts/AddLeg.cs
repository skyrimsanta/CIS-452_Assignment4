/*
     * (Levi Schoof)
     * (AddLeg)
     * (Assignment 4)
     * (Implaments the Mutation Decorator and handles the Extra Leg Mutationn)
     */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLeg : MutationDecorator
{
    public AddLeg(Monster monst)
    {
        this.monster = monst;
    }

    public override string GetDescription()
    {
        return monster.GetDescription() + " Additional Leg Mutation, ";
    }

    public override void PanelText()
    {
        panel.SetActive(true);
        text.text = "Cost: " + 1 + "<br>Damage: " + 0 + "<br>CarryWeight: " + 1 + "<br>Beauty: " + 0;
    }

    public override int GetBeauty()
    {
        return monster.GetBeauty() + 0;
    }

    public override int GetCarryWeight()
    {
        return monster.GetCarryWeight() + 1;
    }

    public override int GetCost()
    {
        return monster.GetCost() + 1;
    }

    public override int GetDamage()
    {
        return monster.GetDamage() + 0;
    }
}
