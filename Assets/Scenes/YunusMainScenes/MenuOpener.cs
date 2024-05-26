using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOpener : MonoBehaviour
{

    public GameObject panel;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            switch(panel.activeSelf)
            {
                case true: 
                panel.SetActive(false);
                break;

                case false:
                panel.SetActive(true);
                break;
            }
        }

        
    }
}
