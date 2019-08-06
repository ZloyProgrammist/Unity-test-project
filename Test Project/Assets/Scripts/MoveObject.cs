using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject moveObject;
    public Transform targetPosition;
    public float speed;
    void Start()
    {
        moveObject = gameObject;
    }

    void Update()
    {
        if (Vector3.Distance(moveObject.transform.position, targetPosition.position) < 2f)
        {
            Destroy(gameObject, 2);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            moveObject.transform.position = Vector3.MoveTowards(moveObject.transform.position, targetPosition.position, Time.deltaTime * speed);
            moveObject.transform.LookAt(targetPosition);            
        }
    }
}
