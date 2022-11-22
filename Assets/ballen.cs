using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballen : MonoBehaviour
{

    public float A; // A
    public float T; // T
    public float f; // f
    float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // lektion 1.11.2021 (tre)

        //float y = Mathf.Sin(Mathf.Deg2Rad.* Time.time);
        
        y = A * Mathf.Sin(2 * Mathf.PI * (1 / T) * Time.time);
        //y += Mathf.Sin(Time.time);
        // transform.position = new Vector3(transform.position.x, y, transform.position.z);

        // float y = A * Mathf.Sin(2 * Mathf.PI * (1 / T) * Time.time);
        // float x = A * Mathf.Cos(2 * Mathf.PI * (1 / T) * Time.time);
        // float z = A * Mathf.Sin(2 * Mathf.PI * (1 / T) * Time.time);
        //transform.position = new Vector3(0, 0, y);
        transform.Rotate(0, 0, y);

    }
}
