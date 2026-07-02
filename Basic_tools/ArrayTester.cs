using UnityEngine;

public class ArrayTester : MonoBehaviour
{
    public string[] dessert = new string[3];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dessert[0] = "Lava Choco cake";
        dessert[1] = "ice cream";
        dessert[2] = "orange cake";
        Debug.Log("Dessert option 1 is :" +dessert[0]);
        Debug.Log("Dessert option 2 is :" +dessert[1]);
        Debug.Log("Dessert option 1 is :" +dessert[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
