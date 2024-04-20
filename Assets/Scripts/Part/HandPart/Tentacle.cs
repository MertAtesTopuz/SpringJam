using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tentacle", menuName = "Part/Hand/Tentacle")]
public class Tentacle : HandPart
{
    public GameObject tentaclePrefab;
    public float  lengthMultiplier = 1f;

    public override void Activate(GameObject parent)
    {
        parent.GetComponent<MonsterController>().range += lengthMultiplier;
    }
}
