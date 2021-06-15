using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye_contact : MonoBehaviour
{
    public static float speed =2f;

    void Start()
    {
        speed = 2f;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ghost")
        {
            Debug.Log("Detect ghost");
            speed = 0f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ghost")
        {
            Debug.Log("out of Detect");
            speed = 2f;
        }
    }
}
