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

    public bool carryingSmthng = false, canBurn = false;
    private bool waitCD = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item"))
        {
            script = other.gameObject.GetComponent<ItemScript>();

            if (Input.GetKeyDown(KeyCode.E) && script != null && !script.isCarrying)
            {
                    script.isCarrying = true;
                    canBurn = false;
            }
        }

       // print(other);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            script = other.gameObject.GetComponent<ItemScript>();

            if (Input.GetKeyDown(KeyCode.E) && script != null)
            {
                if(script.isCarrying && waitCD == false)
                {
                    DropItem();
                    waitCD = true;
                    StartCoroutine(Wait());
                }
                else if (!carryingSmthng && waitCD == false)
                {
                    PickUpItem(other.gameObject);
                    waitCD = true;
                    StartCoroutine(Wait());
                } 
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        waitCD = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && waitCD == false)
        { 
            if (item != null)
            {
                DropItem();
                waitCD = true;
                StartCoroutine(Wait());
            }
            else
            {
                Collider[] colliders = Physics.OverlapSphere(transform.position, 1f);
                foreach (Collider col in colliders)
                {
                    if (col.CompareTag("Item"))
                    {
                        PickUpItem(col.gameObject);
                        waitCD = true;
                        StartCoroutine(Wait());
                        break;
                    }
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
        canBurn = false;
        item.transform.SetParent(transform);
        item.transform.localPosition = Vector3.zero;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.GetComponent<MeshCollider>().isTrigger = true;
    }

    private void DropItem()
    {
        if(item != null)
        {
            script.isCarrying = false;
            carryingSmthng = false;
            canBurn = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.GetComponent<MeshCollider>().isTrigger = false;
            item.GetComponent<Rigidbody>().freezeRotation = false;
            item.transform.SetParent(null);
            item = null;
            script = null;
        }
    }
}
