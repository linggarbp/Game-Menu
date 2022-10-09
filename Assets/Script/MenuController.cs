using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    //Volume Settings
    [SerializeField] private TMP_Text volumeTextValue = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private int defaultVolume = 10;

    //Gameplay Settings
    [SerializeField] private TMP_Text controllerSensTextValue = null;
    [SerializeField] private Slider controllerSensSlider = null;
    [SerializeField] private int defaultSens = 4;
    public int mainControllerSens = 4;

    //Toggle Settings
    [SerializeField] private Toggle subtitle = null;

    //Display Settings
    [SerializeField] private Slider brightnessSlider = null;
    [SerializeField] private TMP_Text brightnessTextValue = null;
    [SerializeField] private float defaultBrightness = 1;

    [Space(10)]
    [SerializeField] private Toggle fullScreenToggle;

    private bool _isFullScreen;
    private float _brightnessLvel;

    //Confirmation
    [SerializeField] private GameObject confirmationPrompt = null;

    //Levels To Load
    public string newGameLevel;
    private string levelToLoad;
    [SerializeField] private GameObject noSaveGame = null;

    public void NewGameYes()
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void LoadGameYes()
    {
        if (PlayerPrefs.HasKey("SavedLevel"))
        {
        levelToLoad = PlayerPrefs.GetString("SavedLevel");
        SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            noSaveGame.SetActive(true);
        }
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void setVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeTextValue.text = volume.ToString("0");
    }

    public void volumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(confirmationBox());
    }

    public void setControllerSens(float sensitivity)
    {
        mainControllerSens = Mathf.RoundToInt(sensitivity);
        controllerSensTextValue.text = sensitivity.ToString("0");
    }

    public void gameplayApply()
    {
        if (subtitle.isOn)
        {
            PlayerPrefs.SetInt("masterSubtitle", 1);
        }
        else
        {
            PlayerPrefs.SetInt("masterSubtitle", 0);
        }

        PlayerPrefs.SetFloat("masterSens", mainControllerSens);
        StartCoroutine(confirmationBox());
    }

    public void setBrightness(float brightness)
    {
        _brightnessLvel = brightness;
        brightnessTextValue.text = brightness.ToString("0");
    }

    public void setFullScreen(bool isFullScreen)
    {
        _isFullScreen = isFullScreen;
    }

    public void displayApply()
    {
        PlayerPrefs.SetFloat("masterBrightness", _brightnessLvel);
        PlayerPrefs.SetInt("masterFullscreen", (_isFullScreen ? 1 : 0));
        Screen.fullScreen = _isFullScreen;
    }

    public void resetButton(string menuType)
    {
        if(menuType == "Display")
        {
            brightnessSlider.value = defaultBrightness;
            brightnessTextValue.text = defaultBrightness.ToString("0");

            fullScreenToggle.isOn = false;
            Screen.fullScreen = false;
            displayApply();
        }

        if(menuType == "Audio")
        {
            AudioListener.volume = defaultVolume;
            volumeSlider.value = defaultVolume;
            volumeTextValue.text = defaultVolume.ToString("0");
            volumeApply();
        }
        if(menuType == "Gameplay")
        {
            controllerSensTextValue.text = defaultSens.ToString("0");
            controllerSensSlider.value = defaultSens;
            mainControllerSens = defaultSens;
            subtitle.isOn = false;
            gameplayApply();
        }
    }
    public IEnumerator confirmationBox()
    {
        confirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        confirmationPrompt.SetActive(false);
    }
}
