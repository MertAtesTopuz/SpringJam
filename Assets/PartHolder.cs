using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartHolder : MonoBehaviour
{
    public PartDebugger partDebugger;

    public HandPart hand;
    public HeadPart head;
    public BodyPart body;

    [Header("UI")]
    public Image handImg;
    public Image headImg;
    public Image bodyImg;

    [Header("Hands")]
    public GameObject clawPrefab;
    public GameObject tentaclePrefab;

    [Header("Heads")]
    public GameObject firePrefab;
    public GameObject acidPrefab;

    [Header("Bodys")]
    public GameObject spikePrefab;
    public GameObject wingPrefab;

    void Update()
    {
        HandCheck(hand);
        HeadCheck(head);
        BodyCheck(body);

        partDebugger.mainBody = body;
        partDebugger.mainHand = hand;
        partDebugger.mainHead = head;
    }

   void HandCheck(HandPart handPart)
   {
        if(handPart != null)
        {
            hand.Activate(gameObject);
            handImg.sprite = hand.partSprite;
            switch (handPart.GetType().ToString())
            {
                case "Claw":
                    print("Claw");
                    clawPrefab.SetActive(true);
                    tentaclePrefab.SetActive(false);
                    break;

                case "Tentacle":
                    print("Tentacle");
                    tentaclePrefab.SetActive(true);
                    clawPrefab.SetActive(false);
                    break;
            }
        }
   }


   void HeadCheck(HeadPart headPart)
   {
        if(headPart != null)
        {
            head.Activate(gameObject);
            headImg.sprite = head.partSprite;
            switch (headPart.GetType().ToString())
            {
                case "FireHead":
                    print("Fire");
                    firePrefab.SetActive(true);
                    acidPrefab.SetActive(false);
                    break;
                
                case "AcidHead":
                    print("Acid");
                    acidPrefab.SetActive(true);
                    firePrefab.SetActive(false);
                    break;
            }
        }
   }

   void BodyCheck(BodyPart bodyPart)
   {
        if(bodyPart != null)
        {
            body.Activate(gameObject);
            bodyImg.sprite = body.partSprite;
            switch (bodyPart.GetType().ToString())
            {
                case "Spike":
                    print("Spike");
                    spikePrefab.SetActive(true);
                    wingPrefab.SetActive(false);
                    break;
                
                case "Wing":
                    print("Wing");
                    wingPrefab.SetActive(true);
                    spikePrefab.SetActive(false);
                    break;
            }
        }
   }

}
