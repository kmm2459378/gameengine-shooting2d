using UnityEngine;

public class GameManager : MonoBehaviour
{    [SerializeField] TMPro.TMP_Text UI_score;

        int score = 0, scoreMin = 0, scoreMax = 9999; int scorefinal = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreInit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ScoreInit()
    {
        score = scoreMin;

        UI_score.SetText(score.ToString());
    }

    public void ScoreAdd(int addScore)
    {
        score += addScore;

        if (score >= scoreMax)
        {
            score = scoreMax;
        }

        UI_score.SetText(score.ToString());
    }

    public void Score(int ScorePule)
    {
        scorefinal += score;
    }
}
