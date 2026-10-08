using System.Collections.Generic;
using UnityEngine;

public class Opdracht1_11 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<string> vijanden = new List<string>();
        vijanden.Add("Goblin");
        vijanden.Add("Ork");
        vijanden.Add("Trol");
        vijanden.Add("Skelet");
        vijanden.Add("Draak");

        vijanden.Remove("Goblin");

        foreach (string vijand in vijanden)
        {
            Debug.Log(vijand);
        }

        Debug.Log("Aantal vijanden: " + vijanden.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
