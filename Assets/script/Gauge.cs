using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Gauge : MonoBehaviour
{
    public float decreaceHp = 0.01f;
    public int HP = 100;
    GameObject airgauge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.airgauge = GameObject.Find("Energygauge");
    }

    // Update is called once per frame  1
    void Update()
    {
        this.airgauge.GetComponent<Image>().fillAmount -= decreaceHp * Time.deltaTime;

        if (this.airgauge.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BossEnemy"))
        {
            HP -= 50;
            this.airgauge.GetComponent<Image>().fillAmount -= 0.5f;
        }

        else if (collision.gameObject.CompareTag("Enemy A"))
        {
            HP -= 10;
            this.airgauge.GetComponent<Image>().fillAmount -= 0.1f;
        }

        else if (collision.gameObject.CompareTag("Enemy C"))
        {
            HP -= 100;
            this.airgauge.GetComponent<Image>().fillAmount -= 1.0f;
        }

        else if (collision.gameObject.CompareTag("Enemy C2"))
        {
            HP -= 100;
            this.airgauge.GetComponent<Image>().fillAmount -= 1.0f;
        }

        else if (collision.gameObject.CompareTag("Enemy B"))
        {
            HP -= 100;
            this.airgauge.GetComponent<Image>().fillAmount -= 1.0f;
        }

        else if (collision.gameObject.CompareTag("Enemy Beem"))
        {
            HP -= 5;
            this.airgauge.GetComponent<Image>().fillAmount -= 0.05f;
        }

        else if (collision.gameObject.CompareTag("Enemy Boom"))
        {
            HP -= 10;
            this.airgauge.GetComponent<Image>().fillAmount -= 0.1f;
        }

        else if (collision.gameObject.CompareTag("Enegy Up"))
        {
            HP += 20;
            this.airgauge.GetComponent<Image>().fillAmount += 0.2f;
        }
    }
}
