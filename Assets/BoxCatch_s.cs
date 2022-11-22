using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoxCatch_s : MonoBehaviour
{
    // Start is called before the first frame update

  
    bool On = false;

    GameObject  boxcatch;
    GameObject WoodBox;
    
    void Start()
    {
       
        
       
        boxcatch = GameObject.Find("Boxcatch");
        WoodBox = GameObject.FindWithTag("WoodBox");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.O))
        {
            if (!On) return;
            //  WoodBox.transform.SetParent(null);
            if (On) {
             
                On = false;
                this.transform.SetParent(null);
                this.GetComponent<BoxCollider>().isTrigger = false;
                this.GetComponent<Rigidbody>().useGravity = true;
                Debug.Log("KeyCode.O ");
            }
            
        }

        if (On) {
           // WoodBox.transform.position = boxcatch.transform.position;
        }
     


    }

    void OnCollisionEnter(Collision collision)
    {
     
    }


    private void OnCollisionExit(Collision collision)
    { 
      

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Boxcatch")
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
            this.GetComponent<Rigidbody>().useGravity = false;

            //  other.transform.position = boxcatch.transform.position;

            // the probelem with sett parent worken one way from objekt to other.
            transform.SetParent(boxcatch.transform);
           // other.transform.SetParent(boxcatch.transform);
            // transform.SetParent(other.transform);
            On = true;
            Debug.Log("WoodBox is Catched! with OnTriggerEnter");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Boxcatchi")
        {
            this.GetComponent<BoxCollider>().isTrigger = false;
            this.GetComponent<Rigidbody>().useGravity = true;


            transform.SetParent(null);

            Debug.Log("WoodBox is Catched! with OnTriggerExit");
        }

    }


   




}
