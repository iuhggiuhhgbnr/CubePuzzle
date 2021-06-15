using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paper_counter : MonoBehaviour
{
    //public GameObject Door;
    bool isComplete;
    Text text;
    public static int paper_amount;
    void Start()
    {
        text = GetComponent<Text>();
        if (paper_amount >= 1)
        {

            paper_amount = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        text.text = paper_amount.ToString();

        if(paper_amount == 3 && !isComplete)
        {
            isComplete = true;
            Debug.Log("the paper is 3");
            //Door.GetComponent<Animation>().Play("Door_Open");
        }
    }
}
