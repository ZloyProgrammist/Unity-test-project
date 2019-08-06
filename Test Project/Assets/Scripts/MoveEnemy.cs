using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    private GameObject Car;
    public float speed;
    public float destroyTime;
    void Start()
    {        
        Destroy(gameObject, destroyTime);
        Car = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        if (Car != null && Vector3.Distance(gameObject.transform.position, Car.transform.position) < 2)
        {
            Destroy(Car);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
