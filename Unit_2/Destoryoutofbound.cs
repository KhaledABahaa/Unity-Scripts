using UnityEngine;

public class Destoryoutofbound : MonoBehaviour
{
    private float topBound =30.0f;
    private float lowBound = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // destroys the game object whenever it leaves the borders whether up or down
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowBound)
        {
            Debug.Log("Game Over!!");
            Destroy(gameObject);
        }
    }
}
