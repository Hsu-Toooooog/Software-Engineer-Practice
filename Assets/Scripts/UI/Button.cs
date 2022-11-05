using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void loadScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
