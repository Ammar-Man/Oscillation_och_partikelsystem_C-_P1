using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendel2 : MonoBehaviour
{
    public float XAngleVelocity;
    public float ZAngleVelocity;
    public float XAngle;
    public float ZAngle;
    float Fg = -9.81f;
    float Fp;
    public float r;

  
    GameObject Sphere , cube;

    public float LastX;
    public float LastZ;
     float v_z;
        float v_x;
    void Start()
    {

        cube = GameObject.Find("Cube_pendel");
        Sphere = GameObject.Find("Sphere_pendel");
        r = Vector3.Distance(transform.position, cube.transform.position);
        LastX = cube.transform.position.x;
        LastZ = cube.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {


     

        XAngle += Mathf.Asin((LastX - cube.transform.position.x) / r);
        ZAngle += Mathf.Asin((LastZ - cube.transform.position.z) / r);

   

            XAngleVelocity += (Fg * (Mathf.Sin(XAngle))) / r * Time.deltaTime;
            ZAngleVelocity += (Fg * (Mathf.Sin(ZAngle))) / r * Time.deltaTime; 

        XAngleVelocity *= 0.98f;
        ZAngleVelocity *= 0.98f;

        //  AdderaXAngleVelocitytillXAngleochZAngleVelocitytill ZAngle
        XAngle += XAngleVelocity * Time.deltaTime;
        ZAngle += ZAngleVelocity * Time.deltaTime;


        LastX = cube.transform.position.x;
        LastZ = cube.transform.position.z;

        //Beräkna x -, y -, och z-koordinat för ”bob” utgåendeffrån XAngleoch ZAngle

        // root in java sqrt()



        float Vinkelx = XAngle + (-90 *Mathf.Deg2Rad);
        float Vinkelz = ZAngle + (-90 * Mathf.Deg2Rad);
       

        //positionen för bob 

        float bob_x = r * Mathf.Cos(Vinkelx);
        float bob_z = r * Mathf.Cos(Vinkelz);
 
      //  float bob_y = r * Mathf.Sin(Vinkelz);

        // Beräkna Y-koordinaten för ”bob”
        float newTestbob;
        float R_bob = (float)Math.Sqrt(bob_x * bob_x + bob_z * bob_z);
        float Q_bob = Mathf.Sin(R_bob/r);
        float YP_bob = Mathf.Cos(Q_bob) * r;



        transform.position = cube.transform.position + new Vector3(bob_x, -YP_bob, bob_z);

        if (Input.GetKey(KeyCode.W))
        {
            if (r <= 1f) return;
            r -= 0.1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (r >= 11f) return;
            r += 0.1f;
        }

    }

}
