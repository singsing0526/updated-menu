using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{


    public GameObject mainMenuHolder;
    public GameObject optionMenuHolder;

    public Slider[] volumeSliders;
    public Toggle[] resolutionToggles;
    public int[] screenWidths;
    int activeScreenResIndex;

    void Start()
    {

        activeScreenResIndex = PlayerPrefs.GetInt("sreen res index");
        bool isFullScreen = (PlayerPrefs.GetInt("fullscreen") == 1) ? true : false;
        for(int i=0; i<resolutionToggles.Length; i++)
        {
            resolutionToggles[i].isOn = i == activeScreenResIndex;
        }
        SetFullScreen(isFullScreen);
    }
    public void Playgame()
    {
        SceneManager.LoadScene("book");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OptionMenu()
    {
        mainMenuHolder.SetActive(false);
        optionMenuHolder.SetActive(true);
    }

    public void MainMenu()
    {
        mainMenuHolder.SetActive(true);
        optionMenuHolder.SetActive(false);
    }
    
    public void SetScreenResolution(int i)
    {
        if(resolutionToggles[i].isOn)
        {
            activeScreenResIndex = i;
            float apspectRatio = 16 / 9f;
            Screen.SetResolution(screenWidths[i],(int)(screenWidths [i]/apspectRatio), false);
            PlayerPrefs.SetInt("screen res index", activeScreenResIndex);
        }
    }

    public void SetFullScreen(bool isFullscreen)
    {
        for(int i =0; i<resolutionToggles.Length;  i++)
        {
            resolutionToggles[i].interactable = !isFullscreen;
        }
        if (isFullscreen)
        {
            Resolution[] Allresolution = Screen.resolutions;
            Resolution maxResolution = Allresolution[Allresolution.Length - 1];
            Screen.SetResolution(maxResolution.width, maxResolution.height, true);
        }
        else{
            SetScreenResolution (activeScreenResIndex);
        }
        PlayerPrefs.SetInt("fullscreen", ((isFullscreen) ? 1 : 0));
        PlayerPrefs.Save();
    }
}
