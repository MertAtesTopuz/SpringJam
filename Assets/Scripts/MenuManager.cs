using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenuPnl, settingsPnl, creditsPnl, suggestionText;

    private bool goToZero = true;

    private void Start()
    {
        //StartCoroutine(Wait());
    }

    private void Update()
    {
        if(goToZero == false)
        {
            suggestionText.transform.localScale = new Vector2 (suggestionText.transform.localScale.x + (Time.deltaTime / 1.5f), suggestionText.transform.localScale.y + (Time.deltaTime / 1.5f));
            if (suggestionText.transform.localScale.x >= 1.25f)
            {
                goToZero = true;
            }
        }
        
        if(goToZero == true)
        {
            suggestionText.transform.localScale = new Vector2(suggestionText.transform.localScale.x - (Time.deltaTime / 1.5f), suggestionText.transform.localScale.y - (Time.deltaTime / 1.5f));
            if (suggestionText.transform.localScale.x <= 0.75f)
            {
                goToZero = false;
            }
        }
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitBtn()
    {
        Application.Quit();
    }

    public void CreditsBtn()
    {
        creditsPnl.SetActive(true);
        mainMenuPnl.SetActive(false);
        settingsPnl.SetActive(false);
    }

    public void SettingsBtn()
    {
        creditsPnl.SetActive(false);
        mainMenuPnl.SetActive(false);
        settingsPnl.SetActive(true);
    }

    public void BackBtn()
    {
        creditsPnl.SetActive(false);
        mainMenuPnl.SetActive(true);
        settingsPnl.SetActive(false);
    }

    private void UpScaler()
    {
        suggestionText.transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    private void DownScaler()
    {
        suggestionText.transform.localScale = new Vector3(transform.localScale.x / 1.5f, transform.localScale.y / 1.5f, transform.localScale.z / 1.5f);
    }



    IEnumerator Wait()
    {
        DownScaler();

        yield return new WaitForSeconds(0.6f);

        UpScaler();

        yield return new WaitForSeconds(0.6f);

        StartCoroutine(Wait());
    }
}
