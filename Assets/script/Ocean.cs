using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocean : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, -0.3f, 0);
        if (transform.position.y < -5.0f)
        {
            transform.position = new Vector3(0, 5.0f,transform.position.z);
        }
    }
}
