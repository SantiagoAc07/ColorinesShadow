using UnityEngine;
using UnityEngine.UIElements;

public class CambioColor : MonoBehaviour
{
    public PlayerVariable player;
    public Background background;
    public Gravedad gravedad;
    public LuzJugador luzJugador;
    public UIManager uiManager;

    void Update()
    {
        // Lógica para cambiar el color del jugador
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.colorActual = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            player.colorActual = Color.magenta;
        }

        // Invoca eventos en Background, Gravedad, LuzJugador y UIManager
        background.ActualizarColor(player.colorActual);
        gravedad.ActualizarGravedad(player.colorActual);
        luzJugador.ActualizarColor(player.colorActual);
     //   uiManager.ActualizarColor(player.colorActual);
    }
}