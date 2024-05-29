using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

    private bool canPress = false, itemsFull = false;

    public bool playerGrow = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canPress = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canPress = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canPress = false;
        }
    }

    private void Update()
    {
        itemsFull = FindAnyObjectByType<GameManager>().checkIngredients;

        if(Input.GetKey(KeyCode.E) && canPress && itemsFull)
        {
            playerGrow = true;
        }

        if(!canPress)
        {
            playerGrow = false;
        }
    }
}
