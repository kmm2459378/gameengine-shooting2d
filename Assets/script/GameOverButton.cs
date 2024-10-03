using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOverButton : MonoBehaviour
{
    public Button OnButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnButton.onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        SceneManager.LoadScene("GameScene");
    }
}
