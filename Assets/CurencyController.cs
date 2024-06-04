using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurencyController : MonoBehaviour
{

    public TextMeshProUGUI curencyText;
    public DNACurrency currency;

    void Start()
    {
        
    }

    void Update()
    {
        curencyText.text = currency.currencyAmount.ToString();
    }
}
