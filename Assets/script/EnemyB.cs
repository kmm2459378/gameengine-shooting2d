using UnityEngine.UI;
using UnityEngine;

public class EnemyB : MonoBehaviour
{
    private Rigidbody2D _ri;
    public GameObject EnemySpearPrehab;
    public GameObject EnemySpearPrehab2;
    float _AttackSpeed = 1.0f;
    float _Count = 0;
    Vector3 _Force;
    public  float _speed = -3.0f;
    Vector3 _SpearPosition, _SpearPosition2;
    int HP = 10;
    public GameObject Specialrecover;
    public GameObject HPrecover;
    float Srow;
    int Score_MOB = 0;
    GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        _ri = GetComponent<Rigidbody2D>();
        Srow = Random.Range(0, 2);
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {  
        ContollerAndAttack();

        
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
                if (Srow == 0)
                {
                    Instantiate(Specialrecover, transform.position, Quaternion.identity);
                    Instantiate(Specialrecover, transform.position, Quaternion.identity);
                }

                if (Srow == 1)
                {
                    Instantiate(HPrecover, transform.position, Quaternion.identity);
                    Instantiate(HPrecover, transform.position, Quaternion.identity);
                }
            }

        }

        if (collision.gameObject.CompareTag("Special Attack"))
        {
            gameManager.ScoreAdd(Score_MOB);
            Destroy(gameObject);

            if (Srow == 0)
            {
                Instantiate(Specialrecover, transform.position, Quaternion.identity);
                Instantiate(Specialrecover, transform.position, Quaternion.identity);
            }

            if (Srow == 1)
            {
                Instantiate(HPrecover, transform.position, Quaternion.identity);
                Instantiate(HPrecover, transform.position, Quaternion.identity);
            }
        }
    }

    public void ContollerAndAttack()
    {
        if(transform.position.y <= 4)
        {
            _ri.linearVelocity = Vector2.zero;
            _ri.isKinematic = true;

            this._Count += Time.deltaTime;
            if (this._Count > this._AttackSpeed)
            {
                this._Count = 0;
                _SpearPosition = transform.position + new Vector3(0.35f, 0, 10f);
                _SpearPosition2 = transform.position + new Vector3(-0.35f, 0, 10f);
                Instantiate(EnemySpearPrehab, _SpearPosition, Quaternion.identity);
                Instantiate(EnemySpearPrehab2, _SpearPosition2, Quaternion.identity);
            }
        }

        else
        {
            _Force = new Vector2(0, _speed * Time.deltaTime);
            _ri.AddForce(_Force);
        }
    }

}
