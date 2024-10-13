using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBindingPractice : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Final_Project");
    }
    public void options(){
        SceneManager.LoadScene("New Scene 1");
    }
    public void back(){
        SceneManager.LoadScene("New Scene");
    }

    public void QuitGame(){
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
