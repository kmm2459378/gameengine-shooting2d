using UnityEngine;
using UnityEngine.UI;

public class SpecialGauge : MonoBehaviour
{
    public float IncreaceHp = 0.1f;
    GameObject airgauge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.airgauge = GameObject.Find("Energygauge");
    }

    // Update is called once per frame
    void Update()
    {
        this.airgauge.GetComponent<Image>().fillAmount += IncreaceHp * Time.deltaTime;
       
    }
}
