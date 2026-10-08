using UnityEngine;

public class Opdracht1_9 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Vertel(Speler speler1, Speler speler2)
    {
        Debug.Log("Ik ben " + speler1.naam + " en ik heb " + speler1.HP + " HP en mijn score is " + speler1.Score);
        Debug.Log("Ik ben " + speler2.naam + " en ik heb " + speler2.HP + " HP en mijn score is " + speler2.Score);
    }
}
