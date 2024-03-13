using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public Animator playerAnimator; // Asigna el Animator del personaje
    public Animator leftPanelAnimator; // Asigna el Animator del panel izquierdo
    public Animator rightPanelAnimator; // Asigna el Animator del panel derecho

    void Update()
    {
        // Verifica si el cursor está en el lado derecho de la pantalla
        if (Input.mousePosition.x > Screen.width / 2)
        {
            // Activa las animaciones correspondientes
            playerAnimator.SetBool("MoveRight", false); // Nombre del trigger para mover al personaje a la derecha
            playerAnimator.SetBool("MoveLeft", true);
            leftPanelAnimator.SetBool("Hide", false); // Nombre del trigger para ocultar el panel izquierdo
            leftPanelAnimator.SetBool("Show", true);
            rightPanelAnimator.SetBool("Show", false); // Nombre del trigger para mostrar el panel derecho
            rightPanelAnimator.SetBool("Hide", true);
        }
        else
        {
            // Si el cursor no está en el lado derecho, revierte las animaciones
            playerAnimator.SetBool("MoveLeft", false); // Nombre del trigger para mover al personaje a la izquierda
            playerAnimator.SetBool("MoveRight", true);
            leftPanelAnimator.SetBool("Show", false); // Nombre del trigger para mostrar el panel izquierdo
            leftPanelAnimator.SetBool("Hide", true);
            rightPanelAnimator.SetBool("Hide", false); // Nombre del trigger para ocultar el panel derecho
            rightPanelAnimator.SetBool("Show", true);
        }
    }
}
