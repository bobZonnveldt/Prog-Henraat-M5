using UnityEngine;

public class Opdracht1_2 : MonoBehaviour
{
    int HP = 100;
    bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("HP: " + HP);
        Debug.Log("Is alive: " + isAlive);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            HP -= 35;
            Debug.Log("HP: " + HP);
            Debug.Log("Is alive: " + isAlive);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {  
            HP -= 80;
            Debug.Log("HP: " + HP);
            Debug.Log("Is alive: " + isAlive);
        }
        
        if (HP <= 0)
        {
            isAlive = false;
            Debug.Log("HP: " + HP);
            Debug.Log("Is alive: " + isAlive);
        }

    }
}
