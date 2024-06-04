using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartUIUpdater : MonoBehaviour
{
    public Image bodyImg, headImg, handImg;
    public PartDebugger debugger;
    public Color transparant;
    public Color normal;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(debugger.mainBody != null)
        {
            bodyImg.color = normal;
            bodyImg.sprite = debugger.mainBody.partSprite;
        }
        else
        {
            bodyImg.color = transparant;
        }

        if(debugger.mainHand != null)
        {
            handImg.color = normal;
            handImg.sprite = debugger.mainHand.partSprite;
        }
        else
        {
            handImg.color = transparant;
        }

        if(debugger.mainHead != null)
        {
            headImg.color = normal;
            headImg.sprite = debugger.mainHead.partSprite;
        }
        else
        {
            headImg.color = transparant;
        }
    }
}
