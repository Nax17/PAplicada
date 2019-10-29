using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int _purpleScore = 0, _blueScore = 0, _redScore = 0, _greenScore = 0, _lives = 3;
    public TextMesh PurpleText;
    public TextMesh BlueText;
    public TextMesh RedText;
    public TextMesh GreenText;
    public TextMesh LifeText;
    public enum ScoreType
    {
        Purple,
        Blue,
        Red,
        Green,
        Lives,
        Enemy,
        All
    }
    void Start()
    {
        PurpleText.text = _purpleScore.ToString();
        BlueText.text = _blueScore.ToString();
        RedText.text = _redScore.ToString();
        GreenText.text = _greenScore.ToString();
        LifeText.text = _lives.ToString();
    }
    public void IncrementScore(ScoreType scoreType, int value = 1)
    {
        switch (scoreType)
        {
            case ScoreType.Purple:
                _purpleScore += value;
                UpdateScoreText(ScoreType.Purple);
                break;
            case ScoreType.Blue:
                _blueScore += value;
                UpdateScoreText(ScoreType.Blue);
                break;
            case ScoreType.Red:
                _redScore += value;
                UpdateScoreText(ScoreType.Red);
                break;
            case ScoreType.Green:
                _greenScore += value;
                UpdateScoreText(ScoreType.Green);
                break;
            case ScoreType.Lives:
                _lives += value;
                UpdateScoreText(ScoreType.Lives);
                break;
        }
    }
    void UpdateScoreText(ScoreType scoreType)
    {
        if (scoreType == ScoreType.All || scoreType == ScoreType.Purple)
            PurpleText.text = _purpleScore.ToString();
        if (scoreType == ScoreType.All || scoreType == ScoreType.Blue)
            BlueText.text = _blueScore.ToString();
        if (scoreType == ScoreType.All || scoreType == ScoreType.Red)
            RedText.text = _redScore.ToString();
        if (scoreType == ScoreType.All || scoreType == ScoreType.Green)
            GreenText.text = _greenScore.ToString();
        if (scoreType == ScoreType.All || scoreType == ScoreType.Lives)
            LifeText.text = _lives.ToString();
    }
}
