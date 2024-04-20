using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public GameObject hand;
    public HeadPart mainHeadPart;
    public BodyPart mainBodyPart;
    public HandPart mainHandPart;

    public bool isCarrying;

    private void Update()
    {

        if(isCarrying == true)
        {
            transform.position = hand.transform.position;
        }
        else
        {
            transform.position = transform.position;
        }

        if(transform.position.y < 1.3f)
        {
            transform.position = new Vector3 (transform.position.x, 1.3f, transform.position.z);
        }
    }
}
