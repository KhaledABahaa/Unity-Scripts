using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class Moveforward : MonoBehaviour
{
    public float speed = 20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        // makes object move foward at a certain pace
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
