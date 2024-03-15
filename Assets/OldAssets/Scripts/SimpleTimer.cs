using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimpleTimer : MonoBehaviour
{
    public TMP_Text tex; // Referencia al componente de texto para mostrar el temporizador
    float countdown = 0; // Tiempo inicial del temporizador (en segundos)

    void Update()
    {
        if (countdown >= 0) // Cambia el operador a "mayor o igual"
        {
            countdown += Time.deltaTime; // Incrementa el temporizador
        }
    }
}
