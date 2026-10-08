using UnityEngine;

public class Opdracht1_6 : MonoBehaviour
{
    string[] Vijanden = { "Orc", "Knight", "Ogre", "Dragon","Wizard" };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < Vijanden.Length; i++)
        {
            Debug.Log(Vijanden[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
