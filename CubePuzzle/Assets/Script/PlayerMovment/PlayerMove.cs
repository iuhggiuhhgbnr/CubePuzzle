using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public CharacterController controller;
    [SerializeField]
    protected float speed_of_player = 6f;
    [SerializeField]
    protected float gravity = -9.8f;
    [SerializeField]
    protected float jump = 1f;

    public Transform groundcheck;
    private float groundDistance = 0.1f;
    public LayerMask groundMask;
    
     
    Vector3 velocity;
    bool isGrounded;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
            Debug.Log("Char jump");
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right* x+ transform.forward *z;

        controller.Move(move* speed_of_player * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime; ;

        controller.Move(velocity * Time.deltaTime);
    }
}
