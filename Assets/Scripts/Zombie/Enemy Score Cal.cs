using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreCal : MonoBehaviour
{
    [SerializeField]
    private int _killScore;

    private ScoreController _scoreController;

    private void Awake()
    {
        _scoreController = FindObjectOfType<ScoreController>();
    }

    public void CalculatorScore()
    {
        _scoreController.AddScore(_killScore);
    }
}
