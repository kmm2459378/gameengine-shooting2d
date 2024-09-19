using UnityEngine;

public class EnemySpearC : MonoBehaviour
{
     GameObject Player; // �v���C���[�̎Q�Ƃ�ǉ�
    public float _speed = 3.0f; // ���̑��x��ݒ�
    Vector3 _Force;
    private Rigidbody2D _rb;
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
        // �v���C���[�Ɍ������đ��x��ݒ�
        _rb.linearVelocity = direction * _speed;
    }
}
