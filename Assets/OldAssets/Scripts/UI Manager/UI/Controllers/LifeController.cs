using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public List<HearthView> heartViews = new List<HearthView>();

    private void Start()
    {
        UpdateLife(3);  // Inicialmente, tienes 3 vidas llenas
    }

    public void UpdateLife(int remainingLives)
    {
        int maxHearts = Mathf.Min(remainingLives, heartViews.Count);  // Limitar el n�mero de corazones al n�mero de HeartViews

        for (int i = 0; i < heartViews.Count; i++)
        {
            if (i < maxHearts)
            {
                // Si la vida est� presente, no hacemos nada especial, ya que las bolas no deben volverse opacas
            }
            else if (i == maxHearts)
            {
                // Si la vida no est� presente, ajustamos la opacidad de la �ltima bola
                heartViews[i - 1].LoseBall();
            }
        }
    }
}

