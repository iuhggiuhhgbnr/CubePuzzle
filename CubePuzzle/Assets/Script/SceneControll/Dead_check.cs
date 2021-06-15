using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead_check : MonoBehaviour
{
    [SerializeField]
    protected int dead_returnto;
    void OnCollisionEnter(Collision col)
    {
       
        if (col.gameObject.tag == "Player")
        {
            //Auto_Flip.start_time = ;
            Debug.Log("Portal collision");
            SceneManager.LoadScene(dead_returnto);
        }
    }
}
