using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class AudioCharacter : MonoBehaviour
{
    public AudioClip walkClip;
    private AudioSource source;

    private bool playAgain = true;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) && playAgain == true)
        {
            /*Invoke("PlayWalkingSound", 0.57f);
            playAgain = false;*/

            StartCoroutine(Walk());
        }
        else if(Input.GetKey(KeyCode.W) == false)
        {
            source.Stop();
        }
    }

    IEnumerator Walk()
    {
        playAgain = false;
        source.PlayOneShot(walkClip);
        yield return new WaitForSeconds(0.57f);
        playAgain = true;

    }



    //Kalsın...
    private void WalkSound(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            source.PlayOneShot(walkClip);
        }
    }
}
