using UnityEngine;

public class Opdracht1_7 : MonoBehaviour
{
    int[] scores = { 10, 20, 30, 40, 50 };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int vindhooste(int[] scores)
    {
        int hoogste = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > hoogste)
            {
                hoogste = scores[i];
            }
        }
        return hoogste;
    }
    void Start()
    {
        int highestScore = vindhooste(scores);
        Debug.Log(highestScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
