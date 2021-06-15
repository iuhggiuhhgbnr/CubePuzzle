using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    private int CurrentScene;

    public void GoMenu()
    {
        CurrentScene = PlayerPrefs.GetInt("SaveScene");

        if (CurrentScene != 0)
            SceneManager.LoadScene(CurrentScene);
        else
            return;

    }
}
