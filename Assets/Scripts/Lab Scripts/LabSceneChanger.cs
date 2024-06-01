using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabSceneChanger : MonoBehaviour
{
    private bool up = false;

    private void Update()
    {
        Debug.Log(up);

        if(up == true && Input.GetKey(KeyCode.E))
        {
            up = false;

            SceneManager.LoadScene(1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            up = true;
        }
        else
        {
            up = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            up = false;
        }
    }
}
