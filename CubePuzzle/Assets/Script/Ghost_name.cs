using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ghost_name : MonoBehaviour
{
    TextMesh text;
    public static string ghostname;
    void Start()
    {
        text = gameObject.GetComponent("TextMesh") as TextMesh;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ghostname.ToString();
    }
}
