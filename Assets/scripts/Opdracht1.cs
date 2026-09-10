using UnityEngine;

public class Opdracht1 : MonoBehaviour
{
    string naam = "jimbo";
    int score = 0;
    bool isalive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Naam: " + naam);
        Debug.Log("Score: " + score);
        Debug.Log("Is alive: " + isalive);
    }
}
