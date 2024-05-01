using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioCharacter : MonoBehaviour
{

    public AudioClip walkClip;
    private AudioSource source;

    private Rigidbody rb;
    private bool playAgain = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && playAgain == true)
        {
            Invoke("PlayWalkingSound", 0.57f);
            playAgain = false;
        }
    }

    private void PlayWalkingSound()
    {
        source.PlayOneShot(walkClip);
        playAgain = true;
    }
}
