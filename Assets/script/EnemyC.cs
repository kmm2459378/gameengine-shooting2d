using System;
using UnityEngine;

public class EnemyC : MonoBehaviour
{
    public GameObject EnemySpearPrehab;
    private Rigidbody2D _ri;
    float _AttackSpeed = 0.5f;
    float _Count = 0;
    Vector3 _Force;
    public float _speed = -100.0f;
    Vector3 _SpearPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        _ri = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ContollerAndAttack();

      
    }

    public void ContollerAndAttack()
    {
        if (transform.position.x <= 1)
        {
            _ri.linearVelocity = Vector2.zero;
            _ri.isKinematic = true;

            this._Count += Time.deltaTime;
            if (this._Count > this._AttackSpeed)
            {
                this._Count = 0;
                _SpearPosition = transform.position + new Vector3(0, 0, 10f);

                Instantiate(EnemySpearPrehab, _SpearPosition, Quaternion.identity);

            }
        }

        else
        {
            _Force = new Vector2(_speed , 0);
            _ri.AddForce(_Force);
        }
    }

    
}

