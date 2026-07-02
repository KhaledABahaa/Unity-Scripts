using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontrol : MonoBehaviour
{
    public InputAction moveAction;
    public Vector2 moveInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject pizzaPrefab;
    public InputAction fireAttack;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
        fireAttack.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // make sure the player doesn't fall off the map by palcing borders on each side.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // reads ythe keys pressed in x,y form
        moveInput = moveAction.ReadValue<Vector2>();
        // moves the character at s certain pace from left to right
        transform.Translate(Vector3.right * speed * Time.deltaTime * moveInput.x);
        // makes the player shoot pizza when the button is clicked
        if (fireAttack.triggered)
        {
            Instantiate(pizzaPrefab, transform.position, pizzaPrefab.transform.rotation);
            Debug.Log("Pizza fired!!");
        }
    }
}
