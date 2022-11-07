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
            if(fish != null) //fish componenti var mý diye kontrol eder.
            {
                fish.FishHealth -= Time.deltaTime * 100;
            }
            //dokunduðun nesnenin Componentini çek, Fish healthine eriþ ve düþür.
            //fish.FishHealth -= Time.deltaTime;
            //other.GetComponent<Fish>().FishHealth -= Time.deltaTime
            Debug.Log("Balýk degdi");


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
