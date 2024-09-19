using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyGauge : MonoBehaviour

{    public float decreaceHp = 0.001f;
    GameObject airgauge;
    
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    private RectTransform rectTransform;

    public void SetTarget(Transform target, Vector3 offset)
    {
        this.target = target;
        this.offset = offset;
        RefreshPosition();
    }
    public void SetTarget(Transform target)
    {
        SetTarget(target, Vector3.zero);
    }

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        this.airgauge = GameObject.Find("Energygauge");
    }

    // Update is called once per frame
    void Update()
    {   
        this.airgauge.GetComponent<Image>().fillAmount -= decreaceHp * Time.deltaTime;
        RefreshPosition();
    }
    private void RefreshPosition()
    {
        if (target != null)
        {
            // World Position‚ðScreen Position‚É•ÏŠ·
            Vector2 screenPos = Camera.main.WorldToScreenPoint(target.position + offset);
            rectTransform.position = screenPos;
        }
    }
}
