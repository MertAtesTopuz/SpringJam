using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class SceneController : MonoBehaviour
{
    private PlayableDirector custscene;
    public bool isEnd;
    

    // Start is called before the first frame update
    void Start()
    {
        custscene = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        isEnd = FindAnyObjectByType<NextScene>().playerGrow;

        if(isEnd== true)
        {
            custscene.Play();
        }
    }
}
