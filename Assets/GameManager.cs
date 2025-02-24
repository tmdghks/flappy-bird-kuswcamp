using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton pattern
    private int score = 0; // Player score
    public TextMeshProUGUI scoreText; // Score UI  

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    
    // add score function
    public void AddScore(int amount)
    {
        score += amount; // add score
        UpdateScoreUI(); 
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
