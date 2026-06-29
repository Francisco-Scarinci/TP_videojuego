using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveArea : MonoBehaviour
{
    public float timer = 60f;

    private UIManager uiManager;
    public bool juegoTerminado = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1; //Para que la partida no empieze congelada luego de haber parado el tiempo al finalizarla
        uiManager = FindAnyObjectByType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (juegoTerminado) {

            if (Input.GetKeyDown (KeyCode.R)) {
                SceneManager.LoadScene (SceneManager.GetActiveScene().name);
            }

            return;
        }
        
        if (timer > 0) {
            timer -= Time.deltaTime;

        if (timer < 0) {
            timer = 0;
            uiManager.timerText.text = "";
            uiManager.MostrarPantallaGameOver();
            Time.timeScale = 0;
            juegoTerminado = true; //El código termina acá, se muestra el mensaje y despues se espera al input del usuario para reiniciar la partida
        }

        }
    
        uiManager.UpdateTimer (timer);
    }
}