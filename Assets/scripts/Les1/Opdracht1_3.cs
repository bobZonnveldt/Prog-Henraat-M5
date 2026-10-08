using UnityEngine;

public class Opdracht1_3 : MonoBehaviour
{
    public void begroeting(string naam)
    {
        Debug.Log("Hallo, " + naam + "!");   
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        begroeting("Bob");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
