using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartUIUpdater : MonoBehaviour
{
    public Image bodyImg, headImg, handImg;
    public PartDebugger debugger;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bodyImg.sprite = debugger.mainBody.partSprite;
        handImg.sprite = debugger.mainHand.partSprite;
        headImg.sprite = debugger.mainHead.partSprite;
    }
}
