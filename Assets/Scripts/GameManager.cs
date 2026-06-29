using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;

    private UIManager uiManager;
    public bool juegoTerminado = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiManager = FindAnyObjectByType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (juegoTerminado) {
            return;
        }
        
        if (timer > 0) {
            timer -= Time.deltaTime;

        if (timer < 0)
            timer = 0;

        }

      uiManager.UpdateTimer (timer);
    }
}
