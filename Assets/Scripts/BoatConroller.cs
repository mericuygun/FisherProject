using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatConroller : MonoBehaviour
{
    public float speed;
    public FixedJoystick variableJoystick;
    public Rigidbody rb;
    ParticleSystem.EmissionModule motorFoam;
    //Health health = new Health();
    //Fish fish = new();
    bool isPressed;

    private void Start()
    {
        //motorFoam = GameObject.GetComponents<ParticleSystem>();
    }

    public void FixedUpdate()
    {
        if (isPressed)
        {
            BoatMovement();
        }

        

    }

    public void BoatMovement()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.velocity = new Vector3(variableJoystick.Horizontal * speed, 0.0f, variableJoystick.Vertical * speed);        
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.15F);

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isPressed = true;
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            isPressed = false;
            
        }
    }
    //private void MotorFoam()
    //{
    //    if(rb.velocity == 0)
    //    {
    //        motorFoam = null;

    //    }
    //}
    //public void OnCollisionStay(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Fish")
    //    {
    //        fish.FishHealth -= Time.deltaTime;
    //    }
    //}

}