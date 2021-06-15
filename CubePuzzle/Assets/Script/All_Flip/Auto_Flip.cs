using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Auto_Flip : MonoBehaviour
{
    //Auto_Flip.start_time
    //public GameObject Fliptrap;
    bool method_check;

    public static float start_time = 0;
    public static float time;


    [SerializeField ]
    private float start_time_seri ;
    void Start()
   {
        start_time = start_time_seri;
    }
  



    void Update()
    {
        time -= Time.deltaTime;
        Debug.Log("start_time_seri;");     //Make this for not letting the log tell that you never assign the value


        if (time <= 0f)
        {
            time = start_time;
            if (method_check == true)
            {
                Debug.Log("FLip1");
                 method_check = !method_check;
                //Fliptrap.GetComponent<Animation>().Play("Fliptrap_animation");
            }
            else 
            {
                Debug.Log("Flip2");
                method_check = !method_check;
                //Fliptrap.GetComponent<Animation>().Play("Fliptrap_animation2");
            }
        }
    }
}
