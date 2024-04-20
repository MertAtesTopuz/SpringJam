using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenuPnl, settingsPnl, creditsPnl;

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
}
