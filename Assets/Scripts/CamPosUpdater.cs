using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPosUpdater : MonoBehaviour
{
    public GameObject cam;
    public GameObject player;
    [SerializeField] float mesafeX;
    [SerializeField] float mesafeY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void CameraPos()
    {
       transform.position = transform.position;
    }
}
