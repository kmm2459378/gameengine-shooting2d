using UnityEngine;
using UnityEngine.UIElements;

public class Prehab : MonoBehaviour
{
    public GameObject EnemyAPrehab;
    public GameObject BossEnemyPrehab;
    public GameObject EBP;
    public GameObject ECP;
    public GameObject ECP2;
    float _span = 3.0f;
    float _delta = 0;
    float _span2 = 5.0f;
    float _delta2 = 0;
    float _span3 = 10.0f;
    float _delta3 = 0;
    float Position = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        enemyAPrehab();

        bossEnemyPrehab();

        EnemyBPrehab();

        EnemyCSecand();
    }

    public void enemyAPrehab()
    {
        this._delta += Time.deltaTime;

        if (this._delta > this._span )
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
            float px = Random.Range(-2.5f, 3.3f);
            Bs.transform.position = new Vector2(4, px);
        }
    }
    public void EnemyBPrehab()
    { 
        this._delta3 += Time.deltaTime;

        if (this._delta3 > this._span2)
        {
            this._delta3 = 0;
            GameObject B = Instantiate(EBP);
            B.transform.position = new Vector3(0, 6, 10.0f);
        }
    }

    public void EnemyCSecand()
    {
        this._delta2 += Time.deltaTime;
         Position = Random.Range(0, 3);
        if (this._delta2 > this._span2 && Position == 0  )
        {
            this._delta2 = 0;
            GameObject C = Instantiate(ECP);
            C.transform.position = new Vector3(-2.7f, 4, 10.0f);

            GameObject C2 = Instantiate(ECP2);
            C2.transform.position = new Vector3(2.7f, 4, 10.0f);
        }

        
        else if (this._delta2 > this._span2 && Position == 1)
        {
            this._delta2 = 0;
            GameObject C = Instantiate(ECP);
            C.transform.position = new Vector3(-2.7f, 3, 10.0f);

            GameObject C2 = Instantiate(ECP2);
            C2.transform.position = new Vector3(2.7f, 3, 10.0f);
        }
        else if (this._delta2 > this._span2 && Position == 2)
        {
            this._delta2 = 0;
            GameObject C = Instantiate(ECP);
            C.transform.position = new Vector3(-2.7f, 2, 10.0f);

            GameObject C2 = Instantiate(ECP2);
            C2.transform.position = new Vector3(2.7f, 2, 10.0f);
        }
    }

}
