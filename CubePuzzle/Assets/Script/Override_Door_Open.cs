using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Override_Door_Open : Door_Open
{
    override protected void Update()
    {

        if (Paper_counter.paper_amount == paper_need && !Is_door_open)
        {
            Is_door_open = true;
            Debug.Log("Door open now");
            Door.GetComponent<Animation>().Play("Door_Open");
        }
    }
}
