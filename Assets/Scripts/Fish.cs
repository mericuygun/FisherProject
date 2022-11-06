using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public float FishHealth;

    void Start()
    {
        FishHealth = 100;
    }


    void Update()
    {
        //Health();
    }
    //public void Health()
    //{
    //    FishHealth = 100;
    //}
    //public void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "Boat")
    //    {
    //        FishHealth -= Time.deltaTime;
    //    }
    //}

}
