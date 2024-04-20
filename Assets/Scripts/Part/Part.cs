using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : ScriptableObject
{
    [HideInInspector] public GameObject part;

    public virtual void Activate(GameObject parent)
    {

    }
}
