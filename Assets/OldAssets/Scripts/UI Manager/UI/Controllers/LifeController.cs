using System;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public LifeView lifeViews;
    public IntVariable life;

    public void Subscribe()
    {
        life.OnValueChange += UpdateLife;
    }

    public void UpdateLife(int remainingLives)
    {
        int amount = Math.Clamp(remainingLives, 0, 3);
        lifeViews.SetLifeView(amount);
    }
}

