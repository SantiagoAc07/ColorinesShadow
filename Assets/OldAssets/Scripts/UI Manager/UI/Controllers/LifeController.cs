using System;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public LifeView lifeViews;

    public void UpdateLife(int remainingLives)
    {
        int amount = Math.Clamp(remainingLives, 0, 3);
        lifeViews.SetLifeView(amount);
    }
    
}

