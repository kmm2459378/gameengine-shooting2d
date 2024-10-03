using UnityEngine;
using UnityEngine.UI;

public class SpecialGauge : MonoBehaviour
{   
    public float DecreaceHp = 1.0f;
    GameObject airgauge;
    bool isImageVisible = false;
    float Special = 0.2f;
    float _Save = 0;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.airgauge = GameObject.Find("SpecialButton");

    }

    // Update is called once per frame
    void Update()
    {
        if (!isImageVisible)
        {
            this.airgauge.GetComponent<Image>().fillAmount -= DecreaceHp;
            if (this.airgauge.GetComponent<Image>().fillAmount <= 0)
                this.airgauge.GetComponent<Image>().enabled = true; // •\Ž¦
            {
                isImageVisible = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision )
    {
        if (collision.gameObject.CompareTag("Special Gauge Up") )
        {
            this.airgauge.GetComponent<Image>().fillAmount += Special;
            
        }
    }
}
