using UnityEngine;

public class Prehab : MonoBehaviour
{
    public GameObject EnemyAPrehab;
    public GameObject BossEnemyPrehab;
    public GameObject EBP;
    float _span = 1.0f;
    float _delta = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        enemyAPrehab();

        bossEnemyPrehab();

        EnemyBPrehab();
    }
       
    public void enemyAPrehab()
    {
       this._delta += Time.deltaTime;

        if (this._delta > this._span)
        { 
            this._delta = 0;
            GameObject A = Instantiate(EnemyAPrehab);
            float px = Random.Range(-1.8f, 1.8f);
            A.transform.position = new Vector3(px, 6, 10.0f);
        }
    }

    public void bossEnemyPrehab()
    {
        this._delta += Time.deltaTime;

        if (this._delta > this._span)
        {
            this._delta = 0;
            GameObject Bs = Instantiate(BossEnemyPrehab);
            float px = Random.Range(-2.0f, 3.3f);
            Bs.transform.position = new Vector3(4, px, 10.0f);
        }
    }
    public void EnemyBPrehab()
    {
        this._delta += Time.deltaTime;

        if (this._delta > this._span)
        {
            this._delta = 0;
            GameObject B = Instantiate(EBP);
            B.transform.position = new Vector3(0, 6, 10.0f);
        }
    }

}
