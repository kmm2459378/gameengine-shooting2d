using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CrossButton : MonoBehaviour
{

    GameObject crossButton;
    public float moveSpeed = 5.0f;
    private RectTransform rectTransform;
    private Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();

        rectTransform.anchoredPosition = new Vector3(200, 200, 0);
    }

    // Update is called once per frame
    void Update()
    { 

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }


    public void OnPointerDown()
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform as RectTransform, Input.mousePosition, null, out localPoint);

        float width = rectTransform.rect.width;
        float height = rectTransform.rect.height;

        if (localPoint.x > width / 4 && localPoint.x < 3 * width / 4 && localPoint.y > height / 2)
        {
            moveDirection = Vector2.up;
        }
        else if (localPoint.x > width / 4 && localPoint.x < 3 * width / 4 && localPoint.y < -height / 2)
        {
            moveDirection = Vector2.down;
        }
        else if (localPoint.x < -width / 2)
        {
            moveDirection = Vector2.left;
        }
        else if (localPoint.x > width / 2)
        {
            moveDirection = Vector2.right;
        }
    }
}



