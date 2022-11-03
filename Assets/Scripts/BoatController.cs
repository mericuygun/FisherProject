using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{

    Rigidbody rb;
    private float yatayHareket;
    private float dikeyHaraket;

    public float donusHizi;
    public float hiz;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {

    }

    void FixedUpdate()
    {
        yatayHareket = Input.GetAxis("Horizontal");
        dikeyHaraket = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(yatayHareket * hiz, 0.0f, dikeyHaraket * hiz);
        
        if (rb.velocity != Vector3.zero)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(new Vector3(rb.velocity.x, 0.0f, rb.velocity.z)), Time.deltaTime * donusHizi);
        }
    }
}

