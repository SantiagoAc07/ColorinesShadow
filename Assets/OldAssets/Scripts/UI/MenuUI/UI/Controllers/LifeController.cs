using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{



    //public void UpdateLife(int amount)
    //{
    //}

    public List<HearthView> hearthViews = new List<HearthView>();

    public void UpdateLife(int amount)
    {
      
        foreach (var hearth in hearthViews)
        {
            hearth.UpdateHeart(0); // Actualiza la vista de las vidas (0 = vacío)
        }

        int amountHearth = (int)amount;
        for (int i = 0; i < amountHearth; i++)
        {
            hearthViews[i].UpdateHeart(2); // Actualiza la vista de las vidas (2 = lleno)
        }
        
    }
}
