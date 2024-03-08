using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int puntos = 0;
    public int vidas = 3; // Inicia con 3 vidas
    public string puntosText;
    private bool juegoTerminado = false;

    void Start()
    {
        ActualizarPuntosUI();
    }

    void Update()
    {
        if (!juegoTerminado)
        {
            // Lógica del juego (colisiones, etc.)

            // Ejemplo: Si colisiona con un obstáculo, resta una vida
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RestarVida();
            }
        }
    }

    void RestarVida()
    {
        vidas--;
        ActualizarPuntosUI();

        if (vidas <= 0)
        {
            JuegoTerminado();
        }
    }

    void JuegoTerminado()
    {
        juegoTerminado = true;
        Debug.Log("Game Over");
        // Puedes agregar aquí la lógica para reiniciar el juego, mostrar pantalla de Game Over, etc.
    }

    void ActualizarPuntosUI()
    {
        puntosText = "Vidas: " + vidas; // Muestra las vidas en lugar de los puntos
    }

    public void IncrementarPuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarPuntosUI();
    }
}
