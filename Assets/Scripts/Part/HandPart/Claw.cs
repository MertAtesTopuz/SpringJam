using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Claw", menuName = "Part/Hand/Claw")]
public class Claw : HandPart
{
    public GameObject clawPrefab;
    public float damageMultiplier;

    public override void Activate(GameObject parent)
    {
        
    }
}
