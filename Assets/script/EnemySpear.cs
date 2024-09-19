using UnityEngine;

public class EnemySpear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.2f, 0);

        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }
    }
}
