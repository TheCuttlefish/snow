using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour
{

    Rigidbody rb;
    float x, y;
    Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {

     
        x = Input.GetAxis("Vertical");
        y = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {


        
            rb.AddForce(cam.transform.right * y * 10);
        rb.AddForce(Vector3.Cross( cam.transform.right, Vector3.up) * x * 10);
        //rb.AddForce(-x * 10, rb.velocity.y, y * 10);
    }
}
