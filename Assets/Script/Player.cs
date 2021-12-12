using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalnput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
             GetComponent<Rigidbody>().AddForce(Vector3.up *5,ForceMode.VelocityChange);
             Debug.Log("pass space");
        }

        horizontalnput=Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().velocity=new Vector3(horizontalnput,GetComponent<Rigidbody>().velocity.y,0);
    }
}
