using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillation : MonoBehaviour
{
    public float A; // A
    public float T; // T
    public float f; // f 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // y = 10 * sin ( 2 TT 1/3 5 ) = -0,86

        float y = A * Mathf.Sin(2 * Mathf.PI * (1 / T) * Time.time);
        float x = A * Mathf.Sin(2 * Mathf.PI * (1 / T) * Time.time);
        transform.position = new Vector3(x,0,0);
    }
}
