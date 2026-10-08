using UnityEngine;

public class Opdracht1_5 : MonoBehaviour
{
    int berekenschade(int aanval, int verdediging)
    {
        int schade = aanval - verdediging;
        if (schade < 0)
        {
            return 0;
        }
        else
        {
            return schade;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = berekenschade(10, 5);
        Debug.Log(result);
        int result2 = berekenschade(5, 10);
        Debug.Log(result2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
