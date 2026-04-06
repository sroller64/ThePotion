/*****************************************************************************
// File Name : PlayerMovement.cs
// Author : Shawn Roller
// Creation Date : March 26, 2026
//
// Brief Description : The movement for the player character
*****************************************************************************/
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    private InputAction move;
    private Vector2 moveDirection;
    private Rigidbody rb;
    [SerializeField] private float playerSpeed;
    [SerializeField] Transform cameraPostion;
    /// <summary>
    /// Finds and gets stuff for later in this script
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        move = InputSystem.actions.FindAction("Move");
    }
    /// <summary>
    /// Has the player move with the direction of the camera
    /// </summary>
    private void RotateWithCamera()
    {
        // Has it where whatever the camera is facing is where the player is facing.
        Quaternion PlayerRotation = Quaternion.Euler(0, cameraPostion.eulerAngles.y, 0);
        transform.rotation = PlayerRotation;
    }
    /// <summary>
    /// Lets the player move. 
    /// </summary>
    void Update()
    {
        RotateWithCamera();
        moveDirection = move.ReadValue<Vector2>();
        // Gives the player how fast they are going and what direction they are facing
        rb.linearVelocity = transform.TransformDirection(new Vector3(moveDirection.x * playerSpeed,
        rb.linearVelocity.y, moveDirection.y * playerSpeed));
    }
    /// <summary>
    /// how high the player goes when they bounce.
    /// </summary>
    /// <param name="bounceValue"></param>
    public void Bounce(float bounceValue)
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, bounceValue, rb.linearVelocity.z);
    }
}

