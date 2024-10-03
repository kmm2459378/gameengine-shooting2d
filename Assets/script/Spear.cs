using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.2f, 0);

        if(transform.position.y > 5.2)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BossEnemy"))
        {
            Destroy(gameObject);

        }

        if (collision.gameObject.CompareTag("Enemy A"))
        {
            Destroy(gameObject);

        }

        if (collision.gameObject.CompareTag("Enemy B"))
        {
            Destroy(gameObject);

        }

        if (collision.gameObject.CompareTag("Enemy C2"))
        {
            Destroy(gameObject);

        }

        if (collision.gameObject.CompareTag("Enemy C"))
        {
            Destroy(gameObject);

        }


        if (collision.gameObject.CompareTag("Enemy Boom"))
        {
            Destroy(gameObject);

        }

        if (collision.gameObject.CompareTag("Enemy Beem"))
        {
            Destroy(gameObject);

        }
    }
}
