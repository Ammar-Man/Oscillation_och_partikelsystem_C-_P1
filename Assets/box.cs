using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public float M;
    public float K;
    float G =  9.82f;
    float Y0;
    float speed = 0;
    float friction = 0.95f;

    // Start is called before the first frame update
    void Start()
    {
        Y0 = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        //Tyngdkraften
        float Fg = M * G;

        //Fjäderkraften
        float deltaY = Y0 - transform.position.y;
        float F = deltaY * K;

        //Resulterande kraften
        float Fr = F - Fg;

        // Accelerationene som tyngdkraften ger upphow till.
        float A = Fr / M;

        //Adderar accelrationen till hastigheten
        speed += A * Time.deltaTime;
      
        speed *= friction;

        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
