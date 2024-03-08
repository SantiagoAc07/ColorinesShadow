using UnityEngine;
using UnityEngine.UI;

public class HearthView : MonoBehaviour
{
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private Image imageRender;

    private void Awake()
    {
        imageRender = GetComponent<Image>();
    }

    public void UpdateHeart(int lives)
    {
        switch (lives)
        {
            case 1:
                imageRender.sprite = fullHeart;
                break;
          
            case 0:
                imageRender.sprite = emptyHeart;
                break;
        }
    }
}