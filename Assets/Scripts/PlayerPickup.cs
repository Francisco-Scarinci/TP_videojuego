using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private int contador = 0;
    private UIManager uiManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiManager = FindAnyObjectByType <UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other) {
        if (other.CompareTag ("Pickable")) {
            contador ++;
            uiManager.UpdateScore (contador);

            Destroy (other.gameObject);
        
        if (contador == 6) {

            GameManager gameManager = FindAnyObjectByType <GameManager>();
            gameManager.juegoTerminado = true;

            uiManager.scoreText.text = "";
            uiManager.timerText.text = "";
            uiManager.GameOverText.color = Color.green;
            uiManager.GameOverText.text = "¡Felicidades! ¡Terminaste!";
        }
        }
    }
}
