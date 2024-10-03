using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;
public class BossEnemy : MonoBehaviour
{
    private Rigidbody2D _rd;
    GameObject player;
    float HP = 100.0f;
    public GameObject HPrecover;
    public GameObject Prezent;
    public GameObject Specialrecover;
    float Srow = 0;
    int Score_MOB = 20;
    GameManager gameManager;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.player = GameObject.Find("player");
        _rd = GetComponent<Rigidbody2D>();
       Srow = Random.Range(0, 2);

        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        BossenemySpeed();

      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
           Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player Attack"))
        {
            HP -= 20.0f;
            if(HP < 1.0f)
            {
                Destroy(gameObject);
                gameManager.ScoreAdd(Score_MOB);
                if (Srow == 0)
                {
                  Instantiate(HPrecover, transform.position, Quaternion.identity);
                }
                else if(Srow == 1)
                {
                  Instantiate(Specialrecover, transform.position, Quaternion.identity);
                }
               
            }
        }

        if (collision.gameObject.CompareTag("Special Attack"))
        {
            Destroy(gameObject);

            if (Srow == 0)
            {
                gameManager.ScoreAdd(Score_MOB);
                Instantiate(HPrecover, transform.position, Quaternion.identity);
            }
            else if (Srow == 1)
            {
                gameManager.ScoreAdd(Score_MOB);
                Instantiate(Specialrecover, transform.position, Quaternion.identity);
            }
        }
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
  
    
}
