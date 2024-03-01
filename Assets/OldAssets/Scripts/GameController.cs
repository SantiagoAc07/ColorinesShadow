using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int puntos = 0;
    public float tiempoLimite = 60f; // Tiempo en segundos
    public string tiempoText;
    public string puntosText;
    private bool juegoTerminado = false;

    void Start()
    {
        ActualizarPuntosUI();
        ActualizarTiempoUI();
    }

    void Update()
    {
        if (!juegoTerminado)
        {
            if (tiempoLimite > 0)
            {
                tiempoLimite -= Time.deltaTime;
                ActualizarTiempoUI();
            }
            else
            {
                // Aquí manejas el "Game Over" cuando se agota el tiempo.
                JuegoTerminado();
            }
        }
    }

    void JuegoTerminado()
    {
        juegoTerminado = true;
        Debug.Log("Game Over");
        // Puedes agregar aquí la lógica para reiniciar el juego, mostrar pantalla de Game Over, etc.
    }

    void ActualizarTiempoUI()
    {
        tiempoText= "Tiempo: " + Mathf.Round(tiempoLimite);
    }

    void ActualizarPuntosUI()
    {
        puntosText= "Puntos: " + puntos;
    }

    public void IncrementarPuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarPuntosUI();
    }
}
