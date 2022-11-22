using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hookes_lag : MonoBehaviour
{
    public float M;
    public float K;
    float G =  9.82f;
    float Y0;
    float speed = 0;
    public float friction = 0.5f;
      Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Y0 = transform.position.y;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Tyngdkraften

        float Fg = M * G;

        //Fjäderkraften
        //GetComponent<Rigidbody>().AddForce(0, 10, 0);
        float deltaY = Y0 - transform.position.y;
        float F = deltaY * K;

        Vector3 force = new Vector3(0, F - friction * rb.velocity.y, 0);
        rb.AddForce(force);




        /*

        //Resulterande kraften
        float Fr = F - Fg;

        // Accelerationene som tyngdkraften ger upphow till.
        float A = Fr / M;

        //Adderar accelrationen till hastigheten
        speed += A * Time.deltaTime;
        speed *= friction;


        //    transform.Translate(0, speed , 0);
        transform.Translate(0, speed * Time.deltaTime, 0);

        */
    }
}
