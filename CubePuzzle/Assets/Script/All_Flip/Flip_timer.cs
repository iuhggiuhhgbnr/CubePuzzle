using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flip_timer : MonoBehaviour
{
    Text text;

    float timer;
    public float timestart = 5f;
    void Start()
    {
        text = GetComponent<Text>();
        //timer = Auto_Flip.time;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;       
        text.text = Mathf.RoundToInt(timer).ToString();
        if (timer <= 0f)
        {
            timer = timestart;
            if (timer == 500)
            {
                
            }
            
        }
    }
}
