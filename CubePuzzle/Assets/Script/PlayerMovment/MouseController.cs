using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float mouseSensitive = 200f;
    public Transform Player_Body;
    float xrotate = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")* mouseSensitive * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitive * Time.deltaTime;

        xrotate -= mouseY;
        xrotate = Mathf.Clamp(xrotate, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xrotate, 0f, 0f);
        Player_Body.Rotate(Vector3.up * mouseX);
    }
}
