using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

    private bool canPress = false;

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

    private void Update()
    {
        if(Input.GetKey(KeyCode.E) && canPress)
        {
            SceneManager.LoadScene(2);
        }
    }
}
