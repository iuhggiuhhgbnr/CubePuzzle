using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_Flip3 : MonoBehaviour
{
    public GameObject Fliptrap;
    bool method_check;
    //float start_time = 2f;
    float time;

    void Update()
    {
        time -= Time.deltaTime;


        if (time <= 0f)
        {
            time = Auto_Flip.start_time;
            if (method_check == true)
            {
                Debug.Log("FLIP3");
                method_check = !method_check;
                Fliptrap.GetComponent<Animation>().Play("Fliptrap_animation");
            }
            else
            {
                Debug.Log("FLIP4");
                method_check = !method_check;
                Fliptrap.GetComponent<Animation>().Play("Fliptrap_animation2");
            }
        }
    }
}
