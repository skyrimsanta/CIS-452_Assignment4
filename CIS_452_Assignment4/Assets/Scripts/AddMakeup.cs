/*
     * (Levi Schoof)
     * (AddMakeup)
     * (Assignment 4)
     * (Implaments the Mutation Decorator and handles the Makeup Mutationn)
     */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMakeup : MutationDecorator
{
    public AddMakeup(Monster monst)
    {
        this.monster = monst;
    }

    public override string GetDescription()
    {
        return monster.GetDescription() + " Makeup Mutation, ";
    }

    public override void PanelText()
    {
        panel.SetActive(true);
        text.text = "Cost: " + 1 + "<br>Damage: " + 0 + "<br>CarryWeight: " + 0 + "<br>Beauty: " + 1;
    }

    public override int GetBeauty()
    {
        return monster.GetBeauty() + 1;
    }

    public override int GetCarryWeight()
    {
        return monster.GetCarryWeight() + 0;
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
