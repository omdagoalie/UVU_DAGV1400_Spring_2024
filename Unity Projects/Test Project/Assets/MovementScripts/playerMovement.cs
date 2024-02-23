using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public float sprintSpeed = 12f; 
    public float gravity = -19.62f;
    public Transform gCheck;
    public float groundDistance = 0.4f;
    public float jumpHieght = 0.05f;
    public LayerMask groundMask;
    public bool isSprinting = false;
    private float currentSpeed;
    public float crouchHeight = 0.5f;
    public float crouchSpeed = 5f; 
    private bool isCrouching = false;
    private float originalHeight;

    Vector3 velocity;
    bool isGrounded;
    void Start()
    {
        originalHeight = controller.height;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(gCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprinting = true;
            currentSpeed = sprintSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprinting = false;
            currentSpeed = speed;
        }
        controller.Move(move * currentSpeed * Time.deltaTime);
        
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHieght) * -2f * gravity;
        }
    }
}
