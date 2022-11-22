using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float XAngleVelocity;
    public float ZAngleVelocity;
    public float XAngle;
    public float ZAngle;
    float Fg = -9.81f;
    float Fp;

    // Start is called before the first frame update
    // Fp = Fg * sin(0);
    // m*a = m*g* sin(0);
    // a = g* sin(0);
    // a = (g*sin(0))/r
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // beräkna vinkeln i x-led och z.led som  förorsakats av en förflyttning av lyftkranen och addera till
        // XAngle och ZAngle
     //  float sinV = Fg / Fp;
       // float Az = Fg *Mathf.Sin();

    }

}
