using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private int contador = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other) {
        if (other.CompareTag ("Pickable")) {
            contador ++;
            Debug.Log ("Lápices recolectados: " + contador);

            Destroy (other.gameObject);
        
        if (contador == 6) {
            Debug.Log ("Felicidades, terminaste el juego!");
        }
        }
    }
}
