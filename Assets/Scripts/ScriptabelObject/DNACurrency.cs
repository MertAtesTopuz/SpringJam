using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Currency", menuName = "Currency/DNA")]
public class DNACurrency : ScriptableObject
{
    public string currencyName;
    public int currencyAmount;
}
