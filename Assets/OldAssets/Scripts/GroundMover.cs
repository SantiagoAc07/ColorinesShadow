using UnityEngine;

public class GroundMover : MonoBehaviour
{
    
    public float velocidad = 5f;
    private float tiempoParaIncrementar = 8f;
    private float tiempoTranscurrido = 0f;

    void Update()
    {
        // Mover el suelo hacia atrás
        transform.Translate(-velocidad * Time.deltaTime, 0f, 0f);

        // Incrementar el tiempo transcurrido
        tiempoTranscurrido += Time.deltaTime;

        // Verificar si han pasado 8 segundos
        if (tiempoTranscurrido >= tiempoParaIncrementar)
        {
            // Aumentar la velocidad en un 10%
            velocidad *= 1.1f;
            // Resetear el contador de tiempo
            tiempoTranscurrido = 0f;
        }        //}
    }
}


