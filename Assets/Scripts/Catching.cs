using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catching : MonoBehaviour
{

    Fish fish = new Fish();


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Fish")
        {
            if(fish != null) //fish componenti var m� diye kontrol eder.
            {
                fish.FishHealth -= Time.deltaTime * 100;
            }
            //dokundu�un nesnenin Componentini �ek, Fish healthine eri� ve d���r.
            //fish.FishHealth -= Time.deltaTime;
            //other.GetComponent<Fish>().FishHealth -= Time.deltaTime
            Debug.Log("Bal�k degdi");


        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fish")
        {
            fish = other.GetComponent<Fish>();


        }
    }
}
