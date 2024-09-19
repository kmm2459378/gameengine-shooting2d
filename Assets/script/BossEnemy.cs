using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    private Rigidbody2D _rd;
    GameObject player;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.player = GameObject.Find("player");
        _rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BossenemySpeed();

        BossEnemyCollider();
    }
    
    public void BossenemySpeed()
    {
        //_Force = new Vector3(-2.0f, 0, 10.0f);
        //_rd.AddForce(_Force);
        _rd.linearVelocity = new Vector3(-2.0f, 0, 0);
        if (transform.position.x < -5.0f)
        {
            Destroy(gameObject);
        }
    }
    public void BossEnemyCollider()
    {
        Vector2 E = transform.position;
        Vector2 P = this.player.transform.position;
        Vector2 dir = E - P;
        float d = dir.magnitude;
        float r1 = 1.0f;
        float r2 = 0.6f;
        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
    }
}
