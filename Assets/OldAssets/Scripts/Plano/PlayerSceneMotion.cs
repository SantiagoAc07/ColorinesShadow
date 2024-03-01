using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSceneMotion : MonoBehaviour
{
    private bool gravedadInvertida = false;
    public Color colorGemaAzul = Color.blue;
    public Color colorGemaVerde = Color.green;
    public int puntosGemaAzul = 10;
    public int puntosGemaVerde = 20;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gema"))
        {
            // Obtener el componente SpriteRenderer de la gema
            SpriteRenderer gemaRenderer = other.GetComponent<SpriteRenderer>();

            if (gemaRenderer != null)
            {
                // Verificar el color de la gema y cambiar la gravedad o incrementar puntos en consecuencia
                if (gemaRenderer.color == colorGemaAzul)
                {
                    // Lógica para la gema azul (puedes incrementar puntos u realizar otras acciones)
                    GameController gameController = FindObjectOfType<GameController>();
                    if (gameController != null)
                    {
                        gameController.IncrementarPuntos(puntosGemaAzul);
                    }
                }
                else if (gemaRenderer.color == colorGemaVerde)
                {
                    // Lógica para la gema verde (puedes cambiar la gravedad u realizar otras acciones)
                    CambiarGravedad();
                    GameController gameController = FindObjectOfType<GameController>();
                    if (gameController != null)
                    {
                        gameController.IncrementarPuntos(puntosGemaVerde);
                    }
                }
                // Puedes agregar más condiciones para otros colores si es necesario
            }
        }
    }

    private void CambiarGravedad()
    {
        Physics2D.gravity = gravedadInvertida ? new Vector2(0, -9.81f) : new Vector2(0, 9.81f);
        gravedadInvertida = !gravedadInvertida;
    }
}

