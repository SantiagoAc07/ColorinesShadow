using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsController : MonoBehaviour
{
    public List<NumberValueView> numberValueViews = new List<NumberValueView>();
    private TMP_Text tex;

    public void UpdatePoints(int points)
    {
        for (int i = numberValueViews.Count - 1; i >= 0; i--)
        {
            int currentNumber = points % 10;
            points /= 10;

            numberValueViews[i].SetNumber(currentNumber);
            tex.text = points.ToString("F0");
        }
    }
}