using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_AI : MonoBehaviour
{
    public Transform follow;
    //[SerializeField]
     //float speed = 0.5f;
    void Update()
    {
        transform.LookAt(follow);
        transform.position = Vector3.Lerp(transform.position, follow.position, Eye_contact.speed * Time.deltaTime);
    }
}
