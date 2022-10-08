using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging : MonoBehaviour
{
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
}
