using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor_controll : MonoBehaviour
{
    bool cursorcheck;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !cursorcheck)
        {
            Cursor.lockState = CursorLockMode.None;
            cursorcheck = true;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && cursorcheck)
        {
            Cursor.lockState = CursorLockMode.Locked;
            cursorcheck = false;
        }
    }
}
