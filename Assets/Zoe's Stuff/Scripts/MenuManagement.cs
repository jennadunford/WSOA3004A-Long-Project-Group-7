using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game Scene", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
