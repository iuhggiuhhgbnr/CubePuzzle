using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipTrap : MonoBehaviour
{
    bool Flip_check;
    public GameObject Fliptrap;
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E)&& !Flip_check)
        {
            Fliptrap.GetComponent<Animation>().Play("Fliptrap_animation");
            Flip_check = true;
            
        }

       
        else if (Input.GetKeyDown(KeyCode.E) && Flip_check)
        {
            Fliptrap.GetComponent<Animation>().Play("Fliptrap_animation2");
            Flip_check = false;
        }

    }
}
