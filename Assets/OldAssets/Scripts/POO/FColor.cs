using UnityEngine;

public class FColor : MonoBehaviour
{
    public Choque choque;

    void CapturarColor()
    {
        // Lógica para capturar el color de las gemas
        if (choque.player.colorActual == Color.green)
        {
            // Lógica para color verde
        }
        else if (choque.player.colorActual == Color.magenta)
        {
            // Lógica para color rosado
        }
    }
}
