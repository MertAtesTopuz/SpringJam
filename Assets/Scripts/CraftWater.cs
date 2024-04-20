using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CraftWater : MonoBehaviour
{

    public GameObject item;
    public PartDebugger partDebugger;

    private bool burn;

    private void Update()
    {
        burn = FindAnyObjectByType<Hand>().canBurn;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item") && burn == true)
        {
            item = other.gameObject;
                if (item.GetComponent<ItemScript>().mainHeadPart != null && item.GetComponent<ItemScript>().mainHandPart == null && item.GetComponent<ItemScript>().mainBodyPart == null )
                {
                    partDebugger.mainHead = item.GetComponent<ItemScript>().mainHeadPart;
                }
                else if (item.GetComponent<ItemScript>().mainHandPart != null && item.GetComponent<ItemScript>().mainBodyPart == null && item.GetComponent<ItemScript>().mainHeadPart == null)
                {
                    partDebugger.mainHand = item.GetComponent<ItemScript>().mainHandPart;
                }
                else if (item.GetComponent<ItemScript>().mainBodyPart != null && item.GetComponent<ItemScript>().mainHeadPart == null && item.GetComponent<ItemScript>().mainHandPart == null)
                {
                    partDebugger.mainBody = item.GetComponent<ItemScript>().mainBodyPart;
                }
                else
                {
                    return;
                }
            Destroy(other.gameObject);
        }
    }
}
