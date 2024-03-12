using UnityEngine;
using UnityEngine.UI;

public class LifeView : MonoBehaviour
{
    [Header("Requirements Canvas")]
    public Image[] balls;
    
    [Header("Requirements Sprites")]
    public Sprite transparentSprite;
    public Sprite ballSprite;

    public void SetLifeView(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            balls[i].sprite = ballSprite;
        }

        for (int i = amount; i < balls.Length; i++)
        {
            balls[i].sprite = transparentSprite;
        }
    }
    
}
