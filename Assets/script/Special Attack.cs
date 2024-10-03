using UnityEngine;

public class SpecialAttack : MonoBehaviour
{
    Animator animater;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;

        this.animater = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.5f, 0);

        if (transform.position.y > 12)
        {
            Destroy(gameObject);
        }
    }
}
