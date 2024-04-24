using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PartDebugger partDebugger;

    public bool checkIngredients = false;

    private void Awake()
    {
        partDebugger.mainBody = null;
        partDebugger.mainHand = null;
        partDebugger.mainHead = null;
    }

    private void Update()
    {
        checkIngredients = checkItems();

        Debug.Log(checkIngredients);
    }

    private bool checkItems(bool isFull = false)
    {
        if(partDebugger.mainBody != null && partDebugger.mainHead != null && partDebugger.mainHand != null)
        {
            isFull = true;
        }

        return isFull;
    }

}
