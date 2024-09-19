using UnityEngine;
using UnityEngine.UI;

public class EnergyGaugeUnder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
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
