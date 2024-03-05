using UnityEngine;

public class Gravedad : MonoBehaviour
{
    public void ActualizarGravedad(Color nuevoColor)
    {
        // Lógica para actualizar la gravedad según el nuevo color
        if (nuevoColor == Color.green)
        {
            Physics2D.gravity = new Vector2(0, -9.8f);
        }
        else if (nuevoColor == Color.magenta)
        {
            Physics2D.gravity = new Vector2(0, 9.8f);
        }
    }
}
