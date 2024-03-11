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
        int maxHearts = Mathf.Min(remainingLives, heartViews.Count);  // Limitar el número de corazones al número de HeartViews

        for (int i = 0; i < heartViews.Count; i++)
        {
            if (i < maxHearts)
            {
                // Si la vida está presente, no hacemos nada especial, ya que las bolas no deben volverse opacas
            }
            else if (i == maxHearts)
            {
                // Si la vida no está presente, ajustamos la opacidad de la última bola
                heartViews[i - 1].LoseBall();
            }
        }
    }
}

