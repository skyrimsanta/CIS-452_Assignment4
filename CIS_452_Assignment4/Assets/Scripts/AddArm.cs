/*
     * (Levi Schoof)
     * (AddLeg)
     * (Assignment 4)
     * (Implaments the Mutation Decorator and handles the Extra Leg Mutationn)
     */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddArm : MutationDecorator
{
    public AddArm(Monster monster)
    {
        this.monster = monster;
    }

    public override string GetDescription()
    {
        return monster.GetDescription() + " Additional Arm Mutation, ";
    }

    public override void PanelText()
    {
        panel.SetActive(true);
        text.text = "Cost: " + 1 + "<br>Damage: " + 5 + "<br>CarryWeight: " + 0 + "<br>Beauty: " + 0;
    }

    public override int GetBeauty()
    {
        return monster.GetBeauty() + 0;
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
        return monster.GetDamage() + 1;
    }
}
