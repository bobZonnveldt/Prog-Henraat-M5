using UnityEngine;

public class Opdracht1_8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Speler speler1 = new Speler();
        speler1.naam = "Bob";
        speler1.HP = 100;
        speler1.Score = 0;
        Speler speler2 = new Speler();
        speler2.naam = "Kjelp";
        speler2.HP = 100;
        speler2.Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
public class Speler
{
    public string naam;
    public int HP;
    public int Score;
    
}