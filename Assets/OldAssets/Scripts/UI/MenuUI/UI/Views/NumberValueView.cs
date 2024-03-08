using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberValueView : MonoBehaviour
{
    public TMP_Text tex;
    private float point;
    
    

    

    public void SetNumber(int number)
    {
        tex.text = point.ToString("f0");
    }

}
