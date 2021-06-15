using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyText : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        if(Paper_counter.paper_amount == 3)
        {
            Destroy(this.gameObject);
        }
    }
}
