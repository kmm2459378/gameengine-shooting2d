using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    GameObject airgauge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.airgauge = GameObject.Find("Energygauge");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.airgauge.GetComponent<Image>().fillAmount == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
