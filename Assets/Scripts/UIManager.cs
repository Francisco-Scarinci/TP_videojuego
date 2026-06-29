using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI GameOverText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore (int score) {
        scoreText.text = "Lápices: " + score;
    }

    public void UpdateTimer (float timer) {

        if (timer <= 0) {
            timerText.text = "";
            scoreText.text = "";
            GameOverText.text = "GAME OVER";
        }

        else {
            timerText.text = "00:" + Mathf.CeilToInt(timer).ToString("00");
            GameOverText.text = "";
        }
    }
}
