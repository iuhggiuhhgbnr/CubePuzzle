using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camfal : MonoBehaviour
{
    private Transform lookAt;
    private Vector3 startoffset;
    // Start is called before the first frame update
    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startoffset = transform.position - lookAt.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = lookAt.position + startoffset;
    }
}
