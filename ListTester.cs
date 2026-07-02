using System;
using System.Collections.Generic;
using UnityEngine;

public class ListTester : MonoBehaviour
{
    public List<String> food = new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        food.Add("Pizza");
        food.Add("Shawerma");
        food.Add("Kabsa");
        Debug.Log("1st option on the menu is:" +food[0]);
        Debug.Log("2nd option on the menu is:" +food[1]);
        Debug.Log("3rd option on the menu is:" +food[2]);
        Debug.Log("Total items on the menu" +food.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
