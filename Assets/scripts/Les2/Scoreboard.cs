using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Scoreboard : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       PlayerMovement.pickup += UpdateScore; 
    
       
    }

    void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }
}
