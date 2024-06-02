using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PartBuyerButton : MonoBehaviour
{
    public ItemsToSpawn itemsToSpawn;
    public GameObject text;

    void Start()
    {
        if(itemsToSpawn.isBought == true)
        {
            text.SetActive(true);
        }
    }

    public void WingBuy()
    {
        itemsToSpawn.isBought = true;
        text.SetActive(true);
    }
}
