using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_controll_2 : MonoBehaviour
{
    float speed = 0.2f;
    float rotationSpeed = 1f;
    
    bool OnGravity = true;
    bool OnTarget = false;

    GameObject  arm,  bilen;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Press O key to get out Woodbox of magnet");
        Debug.Log("S Down" + "W UP for magnet ball movment");
        Debug.Log("Arrow <- -> keys to move 3DWagon");
        



        bilen = GameObject.Find("3DWagon");
        arm = GameObject.Find("Arm");
    }

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetKey(KeyCode.UpArrow))
        {
            bilen.transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            bilen.transform.Translate(speed, 0,0 );
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            bilen.transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            bilen.transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            arm.transform.Rotate(0, -rotationSpeed, 0);
        }  
        if (Input.GetKey(KeyCode.D))
        {
            arm.transform.Rotate(0, rotationSpeed, 0);
        }


    }

  

      


     


    }

  

    

