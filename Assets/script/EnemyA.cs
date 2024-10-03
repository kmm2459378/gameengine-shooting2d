using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyA : MonoBehaviour
{
    public GameObject Specialrecover;
    public GameObject HPrecover;
    public float force;
    float Srow;
    private Rigidbody2D rd;
    Vector3 _Force;
    float HP = 9;
    int Score_MOB = 0;
    GameManager gameManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        rd = this.GetComponent<Rigidbody2D>();
        force = Random.Range(-2.0f, -1.0f);
        Srow = Random.Range(0, 2);
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyAC();

    }

    public void EnemyAC()
    {
        _Force = new Vector3(0, force, 0);
        rd.AddForce(_Force);
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player Attack"))
        {
            HP -= 3;
            if (HP < 1)
            {   
                Destroy(gameObject);
                gameManager.ScoreAdd(Score_MOB);               
                if (Srow == 0 )
                {
                    Instantiate(HPrecover, transform.position, Quaternion.identity);
                }
                if (Srow == 1 )
                {
                    Instantiate(Specialrecover, transform.position, Quaternion.identity);

                }
            }
        }

        if (collision.gameObject.CompareTag("Special Attack"))
        {
            Destroy(gameObject);
            gameManager.ScoreAdd(Score_MOB);
            if (Srow == 0 )
            {

                Instantiate(HPrecover, transform.position, Quaternion.identity);
            }
            if (Srow == 1)
            {

                Instantiate(Specialrecover, transform.position, Quaternion.identity);

            }
        }
    }
}

   




