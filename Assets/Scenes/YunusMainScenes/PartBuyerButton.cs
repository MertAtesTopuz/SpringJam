using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PartBuyerButton : MonoBehaviour
{
    public ItemsToSpawn itemsToSpawn;
    public TextMeshProUGUI text;
    public DNACurrency currency;
    public int cost;

    void Start()
    {
        if(itemsToSpawn.isBought == true)
        {
            text.text = "Bought";
        }
    }

    public void WingBuy()
    {
        if (currency.currencyAmount >= cost)
        {
            currency.currencyAmount -= cost;
            itemsToSpawn.isBought = true;
            text.text = "Bought";
        }
    }
}
