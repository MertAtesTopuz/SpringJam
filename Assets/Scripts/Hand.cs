using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Hand : MonoBehaviour
{
    private GameObject item;
    private ItemScript script;

    public bool carryingSmthng = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item"))
        {
            script = other.gameObject.GetComponent<ItemScript>();

            if (Input.GetKeyDown(KeyCode.E) && script != null && !script.isCarrying)
            {
                    script.isCarrying = true;
            }
        }

        print(other);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            script = other.gameObject.GetComponent<ItemScript>();

            if (Input.GetKeyDown(KeyCode.E) && script != null)
            {
                if(script.isCarrying)
                {
                    DropItem();
                }
                else if (!carryingSmthng)
                {
                    PickUpItem(other.gameObject);
                }
                
            }


        }
    }

    private void PickUpItem(GameObject newItem)
    {
        item = newItem;
        script = item.GetComponent<ItemScript>();
        script.isCarrying = true;
        carryingSmthng = true;
        item.transform.SetParent(transform);
        item.transform.localPosition = Vector3.zero;
        item.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void DropItem()
    {
        if(item != null)
        {
            script.isCarrying = false;
            carryingSmthng = false;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.SetParent(null);
            item = null;
            script = null;
        }
    }
}
