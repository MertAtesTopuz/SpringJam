using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    private bool canChange = false;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            canChange = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            canChange= false;
        }
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.E) && canChange == true)
        {
            SceneManager.LoadScene(2);
        }
    }
}
