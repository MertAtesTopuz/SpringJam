using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurencyUpdater : MonoBehaviour
{
    public DNACurrency currency;
    public TextMeshProUGUI currencyText;

    void Start()
    {
        
    }

    void Update()
    {
        currencyText.text = currency.currencyAmount.ToString();
    }
}
