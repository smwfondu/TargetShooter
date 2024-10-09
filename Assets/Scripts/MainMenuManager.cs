using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;

    private void Start()
    {
        if(mainMenu != null && settingsMenu != null)
        {
            mainMenu.SetActive(true);
            settingsMenu.SetActive(false);
        }
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void SettingsButton()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void BackButton()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void ResetHighscoreButton()
    {
        Debug.Log("Clicked reset");
        PlayerPrefs.SetInt("highscore", 0);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
