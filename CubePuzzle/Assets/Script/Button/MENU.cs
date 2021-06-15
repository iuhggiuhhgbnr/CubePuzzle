using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    private int CurrentScene;
    void Start()
    {
        EventManager.AddmenuEvent_Listener(OnMenu);
    }

    
  public void OnMenu()
    {
        CurrentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SaveScene", CurrentScene);
        SceneManager.LoadScene(0);
        
    }


   
}






