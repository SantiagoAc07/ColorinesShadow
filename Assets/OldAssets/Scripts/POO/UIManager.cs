using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerVariable player;
    public Text vidasText;
    public Text puntosText;
    public Text colorText;
    public Text tiempoText;
    public Text gameOverText;

    public float tiempo = 20f;  // Tiempo inicial
    public float velocidadAumento = 1.2f;  // Factor de aumento de velocidad

    void Update()
    {
        // Actualizar el tiempo y la velocidad cada frame
        tiempo -= Time.deltaTime;
        if (tiempo <= 0)
        {
            // Lógica para aumentar la velocidad cada 20 segundos
            tiempo = 20f;
            AumentarVelocidad();
        }

        // Lógica para mostrar game over
        if (player.vidas <= 0)
        {
            MostrarGameOver();
        }

        // Lógica para actualizar las vistas de puntos, tiempo y color del personaje
        vidasText.text = "Vidas: " + player.vidas.ToString();
        puntosText.text = "Puntos: " + player.puntos.ToString();
        colorText.text = "Color: " + player.colorActual.ToString();
        tiempoText.text = "Tiempo: " + Mathf.Round(tiempo).ToString();
    }

    void AumentarVelocidad()
    {
        // Lógica para aumentar la velocidad
        player.puntos++;  // Ejemplo de aumento de puntos al aumentar la velocidad
        velocidadAumento *= 1.2f;  // Ejemplo de aumento de velocidad
    }

    void MostrarGameOver()
    {
        // Lógica para mostrar game over
        gameOverText.gameObject.SetActive(true);
    }

    // Método para eliminar el color del UI al recoger una gema
    public void EliminarColorGema(Color colorGema)
    {
        // Lógica para eliminar el color del UI
        // Por ejemplo, desactivar un objeto que representa la gema recogida en el UI
        GameObject.Find("Gema_" + colorGema.ToString()).SetActive(false);
    }
}