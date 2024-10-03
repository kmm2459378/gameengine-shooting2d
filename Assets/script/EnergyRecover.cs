using UnityEngine;

public class EnergyRecover : MonoBehaviour
{
    private Rigidbody2D _ri;
    Vector3 _Force;
    public float _speed = -0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        _ri = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _Force = new Vector2(0, _speed * Time.deltaTime);
        _ri.AddForce(_Force);
        if (transform.position.y <= -7)
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
    }
}