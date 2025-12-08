using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WallRunning : MonoBehaviour
{
    [Header("Wallrunning")]
    public LayerMask WhatIsWall;
    public LayerMask WhatIsGround;
    public float wallRunForce;
    public float maxWallRunTime;
    private float wallRunTimer;

    [Header("Input")]
    private float horizontalInput;
    private float verticalInput;

    [Header("Detection")]
    public float wallCheckDistance;
    public float minJumpHeight;
    private RaycastHit leftWallHit;
    private RaycastHit rightWallHit;
    private bool wallLeft;
    private bool wallRight;

    [Header("References")]
    public Transform orientation;
    private FirstPersonController pm;
    private Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<FirstPersonController>();
    }



    private void Update()
    {
        CheckForWall();
    }

    private void CheckForWall()
    {
        wallRight = Physics.Raycast(transform.position, orientation.right, out rightWallHit, wallCheckDistance, WhatIsWall);
        wallLeft = Physics.Raycast(transform.position, -orientation.right, out leftWallHit, wallCheckDistance, WhatIsWall);
        // too much.... TOOOOOOOO MUCHHHHHHH
    }

    private bool AboveGround()
    {
        return !Physics.Raycast(transform.position, Vector3.down, minJumpHeight, WhatIsGround);
        // umm.... THIS BETTER WORK 
    }

    private void StateMachine()
    {
        // Getting those cool inputs inputted by the inputer :) 
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        // State 1.... probably Washington. wait no Wallrunning
        if ((wallLeft || wallRight) && verticalInput > 0 && AboveGround())
        {
            // Here is where the cool guy will run along walls like spiderman... 

        }

    }

    private void StartWallRun()
    {

    }

    private void WallRunningMovement()
    {
        
    }

    private void StopWallRun()
    {

    }
}





    
