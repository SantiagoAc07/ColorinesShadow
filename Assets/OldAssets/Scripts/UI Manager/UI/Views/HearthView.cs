using System;
using UnityEngine;
using UnityEngine.UI;

public class HearthView : MonoBehaviour
{
    public Image ballPrefab;  // Prefab de la bola (debe ser un Image)
    public int maxBalls = 3;   // N�mero fijo de bolas
    public Sprite transparentSprite;  // Sprite transparente

    private Image[] balls;      // Array para almacenar las im�genes de las bolas

    private void Awake()
    {
        InitializeBalls();
    }

    private void InitializeBalls()
    {
        balls = new Image[maxBalls];

        // Instanciar las bolas iniciales
        for (int i = 0; i < maxBalls; i++)
        {
            Image ball = Instantiate(ballPrefab, transform);
            ball.gameObject.SetActive(true);
            balls[i] = ball;
        }
    }

    public void LoseBall()
    {
        if (balls != null && balls.Length > 0)
        {
            // Desvanecer la �ltima bola activa
            Image lastBall = balls[balls.Length - 1];
            lastBall.sprite = transparentSprite;
            lastBall.color = new Color(1f, 1f, 1f, 0.5f);  // Puedes ajustar la opacidad seg�n tus necesidades

            // Reducir el contador de bolas
            Array.Resize(ref balls, balls.Length - 1);
        }
    }
}
