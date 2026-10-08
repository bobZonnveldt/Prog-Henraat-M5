using UnityEngine;

public class Opdracht1_10 : MonoBehaviour
{
    Speler[] spelers;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [System.Obsolete]
    void Start()
    {
        spelers = new Speler[2];
        spelers[0] = new Speler();
        spelers[0].naam = "jan";
        spelers[0].HP = 4;
        spelers[0].Score = 40;
        spelers[1] = new Speler();
        spelers[1].naam = "jim";
        spelers[1].HP = 32;
        spelers[1].Score = 3212;

        DrukSpelersAf(spelers);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    void DrukSpelersAf(Speler[] spelers)
    {
        Opdracht1_9 opdracht1_9 = FindObjectOfType<Opdracht1_9>();
        if (opdracht1_9 != null)
        {
            opdracht1_9.Vertel(spelers[0], spelers[1]);
        }
    }
}
