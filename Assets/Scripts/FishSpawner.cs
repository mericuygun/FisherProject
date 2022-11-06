using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject Balik;
    public int xPoz;
    public int zPoz;
    public float balikSayac;
    void Start()
    {
        StartCoroutine(BalikSpawn());
    }
    IEnumerator BalikSpawn()
    {
        while(balikSayac < 10)
        {
            xPoz = Random.RandomRange(-37, 37);
            zPoz = Random.RandomRange(-32, 32);
            Instantiate(Balik, new Vector3(xPoz, -0.5f, zPoz), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            balikSayac += 1;
        }
    }
    
}
