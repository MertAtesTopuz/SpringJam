using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : ScriptableObject
{
    [HideInInspector] public GameObject part;
    public Sprite partSprite;

    public virtual void Activate(GameObject parent)
    {

    }
}
