using UnityEngine;

public class EnemySpearC : MonoBehaviour
{
     GameObject Player; // �v���C���[�̎Q�Ƃ�ǉ�
    public float _speed = 7.0f; // ���̑��x��ݒ�
    Vector3 _Force;
    private Rigidbody2D _rb;
    float  HP = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        this.Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (this.Player.transform.position - transform.position).normalized;

        _Force = new Vector2(_speed , 0);
        
        _rb.linearVelocity = direction * _speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player Attack"))
        {
            HP -= 1;
            if (HP < 1.0f)
            {
                Destroy(gameObject);
            }
        }


        if (collision.gameObject.CompareTag("Special Attack"))
        {
            Destroy(gameObject);
        }
    }
}
