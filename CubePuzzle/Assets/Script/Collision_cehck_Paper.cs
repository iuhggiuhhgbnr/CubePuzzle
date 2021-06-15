using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collision_cehck_Paper : MonoBehaviour
{
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Coin collision");
            Paper_counter.paper_amount += 1;
            Destroy(this.gameObject);   //ทำลายตัวเองเมื่อถูกชน
        }
    }
}
