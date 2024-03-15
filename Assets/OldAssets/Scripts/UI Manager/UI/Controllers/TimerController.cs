using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    public TMP_Text text;

    public void UpdateTime(int seconds)
    {
        text.text = seconds.ToString();
    }
    
}
