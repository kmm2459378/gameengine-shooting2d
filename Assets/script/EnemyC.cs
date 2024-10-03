
using UnityEngine;

public class EnemyC : MonoBehaviour
{
    public GameObject EnemySpearPrehab;
    private Rigidbody2D _ri;
    public float _AttackSpeed = 3.0f;
    float _Count = 0;
    Vector3 _Force;
    public float _speed = 1.0f;
    Vector3 _SpearPosition;
    int HP = 1;
    float Srow = 0;
    public GameObject HPrecover;
    public GameObject Specialrecover;
    int Score_MOB = 10;
    GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        _ri = GetComponent<Rigidbody2D>();
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        Srow = Random.Range(0,16);
        
    }

    // Update is called once per frame
    void Update()
    {
        ContollerAndAttack();

      this._Count += Time.deltaTime;
    }

    public void ContollerAndAttack()
    {
        if (transform.position.x >= -1)
        {
            _ri.linearVelocity = Vector2.zero;
            _ri.isKinematic = true;

            
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

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("Player Attack"))
        {
            HP -= 1;
            if (HP < 1)
            {
                Destroy(gameObject);
                gameManager.ScoreAdd(Score_MOB);
                if (Srow == 7)
                {
                  
                    Instantiate(HPrecover, transform.position, Quaternion.identity);
                }

                if (Srow == 8)
                {
                   
                    Instantiate(Specialrecover, transform.position, Quaternion.identity);
                }
            }

        }
        if (collision.gameObject.CompareTag("Special Attack"))
        {
            Destroy(gameObject);
            gameManager.ScoreAdd(Score_MOB);
            if (Srow == 7)
            {
                Instantiate(HPrecover, transform.position, Quaternion.identity);
            }

            if (Srow == 8)
            {
                Instantiate(Specialrecover, transform.position, Quaternion.identity);
            }
        }   
    }  
}

