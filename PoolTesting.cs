using UnityEngine;

public class PoolTesting : MonoBehaviour
{
    public PoollCreating pool;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ray = pool.GetObject();
            if (ray != null)
            {
                ray.transform.position = transform.position;
                ray.SetActive(true);
            }
        }
    }
}
