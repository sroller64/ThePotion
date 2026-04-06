/*****************************************************************************
// File Name : StartScreen.cs
// Author : Shawn Roller
// Creation Date : March 26, 2026
//
// Brief Description : The code for the start screen
*****************************************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public string tutorial;
    /// <summary>
    /// Clicking the start sends the player to the tutorial.
    /// </summary>
    public void Startgame()
    {
        SceneManager.LoadScene(tutorial);
    }
    /// <summary>
    /// Quits the Game when the player presses it.
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}
