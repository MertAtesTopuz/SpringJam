using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartHolder : MonoBehaviour
{
    public HandPart hand;
    public HeadPart head;
    public BodyPart body;

    void Update()
    {
        HandCheck(hand);
        HeadCheck(head);
        BodyCheck(body);

        hand.Activate(gameObject);
        head.Activate(gameObject);
        body.Activate(gameObject);
    }

   void HandCheck(HandPart handPart)
   {
        if(handPart != null)
        {
            switch (handPart.GetType().ToString())
            {
                case "Claw":
                    print("Claw");
                    break;

                case "Tentacle":
                    print("Tentacle");
                    break;
            }
        }
   }


   void HeadCheck(HeadPart headPart)
   {
        if(headPart != null)
        {
            switch (headPart.GetType().ToString())
            {
                case "FireHead":
                    print("Fire");
                    break;
                
                case "AcidHead":
                    print("Acid");
                    break;
            }
        }
   }

   void BodyCheck(BodyPart bodyPart)
   {
        if(bodyPart != null)
        {
            switch (bodyPart.GetType().ToString())
            {
                case "Spike":
                    print("Spike");
                    break;
                
                case "Wing":
                    print("Wing");
                    break;
            }
        }
   }

}
