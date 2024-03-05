using UnityEngine;

public class Choque : MonoBehaviour
{
    public PlayerVariable player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // L�gica para manejar colisiones con gemas y obst�culos
        if (collision.gameObject.CompareTag("Gema"))
        {
            // L�gica de recolecci�n de gemas
        }
        else if (collision.gameObject.CompareTag("Protuberancia"))
        {
            // L�gica de reducci�n de vidas
            player.vidas--;

            // Lanza un evento de p�rdida de vidas
            if (player.vidas <= 0)
            {
                // L�gica para manejar game over
                FindObjectOfType<Life>().GameOver();
            }
        }
    }
}
