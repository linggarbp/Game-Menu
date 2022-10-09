using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Debugging : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;

    //Main Menu
    public void BtnNewGame()
    {
        Debug.Log("New Game");
    }
    public void BtnLoadGame()
    {
        Debug.Log("Load Game");
    }
    public void BtnOptions()
    {
        Debug.Log("Options");
    }
    public void BtnExit()
    {
        Debug.Log("Exit Game");
    }

    //Confirmation
    public void BtnYes()
    {
        Debug.Log("Yes");
    }
    public void BtnNo()
    {
        Debug.Log("No");
    }
    public void BtnBack()
    {
        Debug.Log("Back");
    }
    public void BtnApply()
    {
        Debug.Log("Apply");
    }
    public void BtnOK()
    {
        Debug.Log("OK");
    }

    //Option
    public void BtnDisplay()
    {
        Debug.Log("Display Settings");
    }
    public void BtnSound()
    {
        Debug.Log("Sound Settings");
    }
    public void BtnGameplay()
    {
        Debug.Log("Gameplay Settings");
    }
    public void BtnDefault()
    {
        Debug.Log("Reset to Default");
    }

    //Toggle
    public void TglMute(bool value)
    {
        if (value)
        {
            Debug.Log("Mute is On");
        }
        else
        {
            Debug.Log("Mute is Off");
        }
    }
    public void TglScreen(bool value)
    {
        if (value)
        {
            Debug.Log("Fullscreen");
        }
        else
        {
            Debug.Log("Windowed");
        }
    }
    public void TglSub(bool value)
    {
        if (value)
        {
            Debug.Log("Subtitle is On");
        }
        else
        {
            Debug.Log("Subtitle is Off");
        }
    }

    //Dropdown
    public void GetReso(int value)
    {
        Debug.Log("Resolution " + dropdown.options[value].text);
    }
    public void GetQuality(int value)
    {
        Debug.Log("Quality " + dropdown.options[value].text);
    }
}
