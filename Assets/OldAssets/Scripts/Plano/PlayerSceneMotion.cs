using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSceneMotion : MonoBehaviour
{
    private bool gravedadInvertida = false;
    public Color colorGemaAzul = Color.blue;
    public Color colorGemaVerde = Color.green;
    public int puntosGemaAzul = 10;
    public int puntosGemaVerde = 10;

    private float velocidadInicial = 1f; // Velocidad inicial del plano
    private float tiempoParaIncrementarVelocidad = 6f; // Tiempo en segundos para incrementar la velocidad
    private float incrementoPorcentaje = 0.1f; // Incremento del 10% cada vez

    private void Start()
    {
        StartCoroutine(IncrementarVelocidad());
    }

    private IEnumerator IncrementarVelocidad()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempoParaIncrementarVelocidad);
            velocidadInicial *= (1f + incrementoPorcentaje); // Incrementa la velocidad en un 10%
            Debug.Log("Nueva velocidad: " + velocidadInicial); // eliminable
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gema"))
        {
            SpriteRenderer gemaRenderer = other.GetComponent<SpriteRenderer>();

            if (gemaRenderer != null)
            {
                if (gemaRenderer.color == colorGemaAzul)
                {
                    GameController gameController = FindObjectOfType<GameController>();
                    if (gameController != null)
                    {
                        gameController.IncrementarPuntos(puntosGemaAzul);
                    }
                }
                else if (gemaRenderer.color == colorGemaVerde)
                {
                    GameController gameController = FindObjectOfType<GameController>();
                    if (gameController != null)
                    {
                        gameController.IncrementarPuntos(puntosGemaVerde);
                    }
                }
                
            }
        }
    }
}

