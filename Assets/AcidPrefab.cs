using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidPrefab : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        rb.velocity = transform.forward * speed;
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
