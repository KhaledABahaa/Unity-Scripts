using System.Collections.Generic;
using UnityEngine;

public class PoollCreating : MonoBehaviour
{
    public GameObject raygun;
    public int poolsize = 10;
    public List<GameObject> pool = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < poolsize; i++)
        {
            GameObject ray = Instantiate(raygun);
            ray.SetActive(false);
            pool.Add(ray);
        }
    }
    public GameObject GetObject()
    {
        foreach (GameObject ray in pool)
        {
            if (!ray.activeInHierarchy)
            {
                return ray;
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
