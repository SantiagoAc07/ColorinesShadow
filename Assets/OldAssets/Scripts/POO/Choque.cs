using UnityEngine;

public class Choque : MonoBehaviour
{
    public PlayerVariable player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Lógica para manejar colisiones con gemas y obstáculos
        if (collision.gameObject.CompareTag("Gema"))
        {
            // Lógica de recolección de gemas
        }
        else if (collision.gameObject.CompareTag("Protuberancia"))
        {
            // Lógica de reducción de vidas
            player.vidas--;

            // Lanza un evento de pérdida de vidas
            if (player.vidas <= 0)
            {
                // Lógica para manejar game over
                FindObjectOfType<Life>().GameOver();
            }
        }
    }
}
