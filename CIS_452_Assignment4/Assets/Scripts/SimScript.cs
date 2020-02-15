/*
     * (Levi Schoof)
     * (SimScript)
     * (Assignment 4)
     * (Handles the Simulation of the buyers)
     */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimScript : MonoBehaviour
{
    public TextMeshProUGUI royalityText;
    public TextMeshProUGUI merchantText;
    public TextMeshProUGUI adventeurText;
    public TextMeshProUGUI endText;
    public TextMeshProUGUI endTotal;
    public TextMeshProUGUI endButton;

    MonsterCreator monster;
    Buyers buyers;

    private float royalityTotal;
    private float merchantTotal;
    private float adventuerTotal;

    private float chancePerMissing = 20;
    private float minChange = 50;

    private float normalBuyPrice = 10;
    private float highBuyPrice = 15;
    private float lowBuyPrice = 5;

    private float lowAmount;
    private float medAmount;
    private float highAmount;
    private float nonPurchase;

    private float winAmmount = 600;
    float total;

    private void Start()
    {
        buyers = FindObjectOfType<Buyers>();
        monster = FindObjectOfType<MonsterCreator>();
    }
    private void Royality()
    {
        lowAmount = 0;
        medAmount = 0;
        highAmount = 0;
        nonPurchase = 0;

        for(int i = 0; i < buyers.royality; i++)
        {
            if (monster.monster.GetBeauty() < buyers.picky)
            {
                float temp = Random.Range(0, 100 - ((buyers.picky - monster.monster.GetBeauty()) * chancePerMissing));
                if (temp >= minChange)
                {
                    lowAmount++;
                    royalityTotal += lowBuyPrice;
                    Debug.Log("Royality Bought at Low Price");
                }

                else
                {
                    nonPurchase++;
                }
            }

           else if (monster.monster.GetBeauty() == buyers.picky)
            {
                medAmount++;
                royalityTotal += normalBuyPrice;
                Debug.Log("Royality Bought at Normal Price");
            }

            else if (monster.monster.GetBeauty() > buyers.picky)
            {
                float temp = Random.Range(0, (buyers.picky - monster.monster.GetBeauty()) * 10);
                if(temp > 20)
                {
                    highAmount++;
                    royalityTotal += highBuyPrice;
                    Debug.Log("Royalty Bought at High Price");
                }

                else
                {
                    medAmount++;
                    royalityTotal += normalBuyPrice;
                    Debug.Log("Royality Bought at Normal Price");
                }
            }
        }

        Debug.Log("Royality Purchase: " + royalityTotal);
        PrintInfo(royalityText, royalityTotal);
    }
    private void Merchant()
    {
        lowAmount = 0;
        medAmount = 0;
        highAmount = 0;
        nonPurchase = 0;

        for (int i = 0; i < buyers.merchants; i++)
        {
            if (monster.monster.GetCarryWeight() < buyers.picky)
            {
                float temp = Random.Range(0, 100 - ((buyers.picky - monster.monster.GetCarryWeight()) * chancePerMissing));
                if (temp >= minChange)
                {
                    lowAmount++;
                    merchantTotal += lowBuyPrice;
                    Debug.Log("Merchant Bought at Low Price");
                }

                else
                {
                    nonPurchase++;
                }
            }

            else if (monster.monster.GetCarryWeight() == buyers.picky)
            {
                medAmount++;
                merchantTotal += normalBuyPrice;
                Debug.Log("Merchant Bought at Normal Price");
            }

            else if (monster.monster.GetCarryWeight() > buyers.picky)
            {
                float temp = Random.Range(0, (buyers.picky - monster.monster.GetCarryWeight()) * 10);
                if (temp > 20)
                {
                    highAmount++;
                    merchantTotal += highBuyPrice;
                    Debug.Log("Merchant Bought at High Price");
                }

                else
                {
                    medAmount++;
                    merchantTotal += normalBuyPrice;
                    Debug.Log("Merchant Bought at Normal Price");
                }
            }
        }
        Debug.Log("Merchant Purchase: " + merchantTotal);
        PrintInfo(merchantText, merchantTotal);
    }
    private void Adventuer()
    {
        lowAmount = 0;
        medAmount = 0;
        highAmount = 0;
        nonPurchase = 0;

        for (int i = 0; i < buyers.adventures; i++)
        {
            if (monster.monster.GetDamage() < buyers.picky)
            {
                float temp = Random.Range(0, 100 - ((buyers.picky - monster.monster.GetDamage()) * chancePerMissing));
                if (temp >= minChange)
                {
                    lowAmount++;
                    adventuerTotal += lowBuyPrice;
                    Debug.Log("Adventeur Bought at Low Price");
                }

                else
                {
                    nonPurchase++;
                }
            }

            else if (monster.monster.GetDamage() == buyers.picky)
            {
                medAmount++;
                adventuerTotal += normalBuyPrice;
                Debug.Log("Adventeur Bought at Normal Price");
            }

            else if (monster.monster.GetDamage() > buyers.picky)
            {
                float temp = Random.Range(0, (buyers.picky - monster.monster.GetDamage()) * 10);
                if (temp > 20)
                {
                    highAmount++;
                    adventuerTotal += highBuyPrice;
                    Debug.Log("Adventuer Bought at High Price");
                }

                else
                {
                    medAmount++;
                    adventuerTotal += normalBuyPrice;
                    Debug.Log("Adventeur Bought at Normal Price");
                }
            }
        }
        Debug.Log("Adventuer Purchase: " + adventuerTotal);
        PrintInfo(adventeurText, adventuerTotal);
    }

    public void RunSim()
    {
        Royality();
        Merchant();
        Adventuer();
        PrintResults();
    }

    private void PrintInfo(TextMeshProUGUI text, float total)
    {
        text.text = "<b>Bought for High Price:</b> " + highAmount + " <b>Ammount Earned:</b> " + (highAmount * highBuyPrice) +
                    "<br><b>Bought for Normal Price:</b> " + medAmount + " <b>Ammount Earned:</b> " + (medAmount * normalBuyPrice) +
                    "<br><b>Bought for Low Price:</b> " + lowAmount + " <b>Ammount Earned:</b> " + (lowAmount * lowBuyPrice) +
                    "<br><b>Did not Buy:</b> " + nonPurchase + "<br><br><b>Total Amount Earned:</b> " + total;

    }

    private void PrintResults()
    {
        total = adventuerTotal + merchantTotal + royalityTotal;
        endTotal.text = "<b>Total: " + total + "</b>";
        if(total >= winAmmount)
        {
            endText.text = "You Won";
        }

        else
        {
            endText.text = "You Lost";
        }
    }
}
