/*
     * (Levi Schoof)
     * (MonsterCreator)
     * (Assignment 4)
     * (Handles the creation and decorating of Monster classes)
     */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MonsterCreator : MonoBehaviour
{
    public Monster monster;
    private MoneyManager money;
    public TextMeshProUGUI curentMonsterDescription;

    private void Start()
    {
        curentMonsterDescription.text = "No Monster Currently";
        money = FindObjectOfType<MoneyManager>();
    }

    public void CreateMonster(string type)
    {
        switch (type)
        {
            case "Goblin":
                this.monster = new Goblin();
                break;
            case "Skeleton":
                this.monster = new Skeleton();
                break;
            case "Siren":
                this.monster = new Siren();
                break;
        }

        ChangeDescription();
        money.NewMonster();
    }

    public void AddMutation(string type)
    {
        if(money.GetRemainingMoney() >= 1)
        {
            switch (type)
            {
                case "Arm":
                    this.monster = new AddArm(this.monster);
                    break;
                case "Leg":
                    this.monster = new AddLeg(this.monster);
                    break;
                case "Makeup":
                    this.monster = new AddMakeup(this.monster);
                    break;

            }
            ChangeDescription();
            money.MadePurchase(monster);
        }
    
    }

    private void ChangeDescription()
    {
        curentMonsterDescription.text = "Description " + monster.GetDescription() + "<br>Damage: " + monster.GetDamage() +
            "<br>CarryWeight " + monster.GetCarryWeight() + "<br>Beauty: " + monster.GetBeauty();
    }
}
