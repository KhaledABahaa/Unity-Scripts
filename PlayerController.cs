using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    // Move action tuning (accessable in inspector)
    public float speed = 5.0f;
    public float turnSpeed = 10.0f;
    //Input system action for connecting (WASD/arrow keys)
    public InputAction moveAction;
    //Current input values (x = left/right, y = forward/backward)
    private Vector2 inputAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Enables the moveAction in order to start reading input
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //Read the 2D vector from moveAction
        inputAction = moveAction.ReadValue<Vector2>();
        //Move the vechile forward/Backward using y component along the z
        transform.Translate(Vector3.forward * Time.deltaTime * speed * inputAction.y);
        //Rotate the vechile left/right around the y using x component  
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * inputAction.x);
    }
}
