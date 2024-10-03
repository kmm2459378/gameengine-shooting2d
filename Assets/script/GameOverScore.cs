using UnityEngine;

public class GameOverScore : MonoBehaviour
{
    int score = 0;
    GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        gameManager.Score(score);
    }
}
