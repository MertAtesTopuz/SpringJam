using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Currency", menuName = "Currency/DNA")]
public class DNACurrency : ScriptableObject
{
    [SerializeField] public string currencyName;
    [SerializeField] public int currencyAmount;
}
