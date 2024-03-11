using System.Collections.Generic;
using UnityEngine;

public class PointsController : MonoBehaviour
{
    public List<NumberValueView> numberValueViews = new List<NumberValueView>();

    public void UpdatePoints( int points )
    {
        foreach (var item in numberValueViews)
        {
            int currentNumber = points % 1;
            points /= 1;

            item.SetNumber( currentNumber );
        }
    }
}