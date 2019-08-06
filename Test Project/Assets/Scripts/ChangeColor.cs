using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else if (Input.GetKey(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
