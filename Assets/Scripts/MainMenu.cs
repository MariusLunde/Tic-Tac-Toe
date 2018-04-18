using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        EditorSceneManager.LoadScene(1);
    }

    public void Back()
    {
        EditorSceneManager.LoadScene(0);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
