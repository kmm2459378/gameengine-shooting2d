using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyA : MonoBehaviour
{   
    GameObject player;
    GameObject BEP;
    public float force;
    private Rigidbody2D rd;
    Vector3 _Force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        this.player = GameObject.Find("player");
        this.BEP = GameObject.Find("BossEnemyPrehab");
        rd = this.GetComponent<Rigidbody2D>();
        force = Random.Range(-20.0f, -10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        EnemyAC();
       
        EAToPlayer();

        
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

    public void EAToPlayer()
    {
        Vector2 E = transform.position;
        Vector2 P = this.player.transform.position;
        Vector2 dir = E - P;
        float d = dir.magnitude;
        float r1 = 0.4f;
        float r2 = 0.3f;
        if(d < r1 + r2)
        {
            Destroy(gameObject);
        }
    }

   




}