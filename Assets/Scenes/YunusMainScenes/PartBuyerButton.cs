using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PartBuyerButton : MonoBehaviour
{
    public ItemsToSpawn itemsToSpawn;
    public Text wingText;

    void Start()
    {
        itemsToSpawn.numberOfSpawn = 0;
    }

    public void WingBuy()
    {
        itemsToSpawn.numberOfSpawn++;
        wingText.text = "" + Mathf.Round(itemsToSpawn.numberOfSpawn);
    }
}
