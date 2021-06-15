using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Scene : MonoBehaviour
{
    [SerializeField]
    protected int nextscene;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Portal collision");
            SceneManager.LoadScene(nextscene);
        }
    }
}
