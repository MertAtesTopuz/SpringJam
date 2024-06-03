using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public Slider healthBar;

    public Godzillah godzillah;

    private void Start()
    {
        //godzillah = GetComponent<Godzillah>();


    }

    private void Update()
    {
        healthBar.value = godzillah.health;
        healthBar.maxValue = godzillah.saveHealth;
    }
}
