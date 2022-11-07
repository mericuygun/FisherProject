using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalikAI : MonoBehaviour
{
    public GameObject balik;
    public bool isMoving;
    public Transform[] waypoints;
    private Transform destination;
    public float fishSpeed;

    void Start()
    {
        isMoving = false;

    }


    void Update()
    {
        if (isMoving == false)
        {
            destination = waypoints[Random.Range(0, waypoints.Length)];
            isMoving = true;
        }

        
        transform.position = Vector3.MoveTowards(transform.position, destination.position, fishSpeed * Time.deltaTime);
        transform.LookAt(destination);
        if (transform.position == destination.position)
        {
            isMoving = false;
        }
    }
}
