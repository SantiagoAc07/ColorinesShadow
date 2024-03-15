using System;
using UnityEngine;

public class UITest : MonoBehaviour
{
    public LifeController lifeController;
    public PointsController pointsController;
    public TimerController timeController;
    public GameOverController gameOverController;
    
    public IntVariable life;
    public IntVariable score;

    private float _segundos = 0;
    private bool _isGameOver = false;

    private void Start()
    {
        gameOverController.Hide();
    }

    public void OnEnable()
    {
        life.OnValueChange += ChangeLifeController;
        score.OnValueChange += ChangeScoreController;
    }

    public void OnDisable()
    {
        life.OnValueChange -= ChangeLifeController;
        score.OnValueChange -= ChangeScoreController;
    }

    private void Update()
    {
        if (!_isGameOver)
        {
            _segundos += Time.deltaTime;
            timeController.UpdateTime( (int) _segundos);
        }
    }

    private void ChangeScoreController(int newvalue)
    {
        pointsController.UpdatePoints(newvalue);
    }

    private void ChangeLifeController(int remainingLives)
    {
        if (remainingLives <= 0)
        {
            _isGameOver = true;
            gameOverController.ShowGameOver((int) _segundos, score.Value);
        }
        lifeController.UpdateLife(remainingLives);
    }
}
