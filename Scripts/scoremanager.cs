using UnityEngine;
using TMPro; // Kita pakai TextMeshPro agar teks tajam

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText; // Tarik 'ScoreNumber' ke sini
    int currentScore = 0;
    int maxApple = 1; // Sesuaikan dengan jumlah apel di levelmu

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore()
    {
        currentScore++;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = currentScore + "/" + maxApple;
    }
}