using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour
{
    [SerializeField]
    protected int paper_need = 3;
    protected bool Is_door_open;
     public GameObject Door;
    virtual protected void Update()
    {

        if (Paper_counter.paper_amount == paper_need && !Is_door_open)
        {
            Is_door_open = true;
            Debug.Log("Door open now");
            Door.GetComponent<Animation>().Play("Door_Open");
        }
    }
}
