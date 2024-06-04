using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBarUI : MonoBehaviour
{
    public Slider healthBar;
    public TextMeshProUGUI healthText;

    public Godzillah godzillah;

    private void Start()
    {
        //godzillah = GetComponent<Godzillah>();


    }

    private void Update()
    {
        healthBar.value = godzillah.health;
        healthBar.maxValue = godzillah.saveHealth;

        healthText.text = godzillah.health.ToString() + " / " + godzillah.saveHealth.ToString();
    }
}
