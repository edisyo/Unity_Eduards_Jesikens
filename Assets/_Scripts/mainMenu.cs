using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void playGame()
    {
        SoundManager.PlaySound("click");
        SceneManager.LoadScene("Game");  
    }

    public void openInstructionScene()
    {
        SoundManager.PlaySound("click");
        SceneManager.LoadScene("Instruction_Scene");
    }

    public void exitGame()
    {
        SoundManager.PlaySound("click");
        Debug.Log("Exited the game!");
        Application.Quit();
        
    }
}
