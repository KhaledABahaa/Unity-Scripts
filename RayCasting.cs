using UnityEngine;

public class RayCasting : MonoBehaviour
{
    private RaycastHit hit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10f ))
        {
            Debug.Log("there is an object up ahead"+hit.collider.name);
        }
    }
}
