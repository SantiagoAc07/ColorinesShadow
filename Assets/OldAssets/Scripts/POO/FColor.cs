using UnityEngine;

public class FColor : MonoBehaviour
{
    public Choque choque;

    void CapturarColor()
    {
        // L�gica para capturar el color de las gemas
        if (choque.player.colorActual == Color.green)
        {
            // L�gica para color verde
        }
        else if (choque.player.colorActual == Color.magenta)
        {
            // L�gica para color rosado
        }
    }
}
