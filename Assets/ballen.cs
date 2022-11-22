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


    void Update()
    {
        y = A * Mathf.Sin(2 * Mathf.PI * (1 / T) * Time.time);
        transform.Rotate(0, 0, y);

    }
}
