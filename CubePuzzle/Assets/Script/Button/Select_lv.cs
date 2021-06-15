using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select_lv : MonoBehaviour
{
    [SerializeField]
    protected int Selection;

    public void StageSelection()
    {
        SceneManager.LoadScene(Selection);
        Debug.Log("button press");
    }
}
