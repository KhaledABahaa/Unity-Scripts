using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // creates a method for when a collision has been triggered
    void OnTriggerEnter(Collider other)
    {
        //destroys gameobject right after collision
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
