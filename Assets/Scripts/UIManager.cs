using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject winPanel;
    public GameObject gameOverPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winPanel.SetActive (false);
        gameOverPanel.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore (int score) {
        scoreText.text = "Lápices: " + score;
    }

    public void MostrarPantallaWin() {
        winPanel.SetActive (true);
    }

    public void MostrarPantallaGameOver() {
        gameOverPanel.SetActive (true);
    }

    public void UpdateTimer (float timer) {

        if (timer <= 0) {
            MostrarPantallaGameOver();
        }

        else {
            timerText.text = "00:" + Mathf.CeilToInt(timer).ToString("00");
        }
    }
}
