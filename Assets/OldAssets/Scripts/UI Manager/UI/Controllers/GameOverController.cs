using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public TMP_Text timeText;
    public TMP_Text pointsText;
    
    public void ShowGameOver(int time, int points)
    {
        gameOverCanvas.SetActive(true);
        timeText.text = time.ToString();
        pointsText.text = points.ToString();
    }

    public void Hide()
    {
        gameOverCanvas.SetActive(false);
    }
    
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
