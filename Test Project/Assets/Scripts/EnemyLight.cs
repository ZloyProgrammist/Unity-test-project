using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLight : MonoBehaviour
{

    private GameObject _target;
    public Vector3 _rotation;
    public float speed;
    Quaternion startRot;
    private void Start()
    {
        startRot = gameObject.transform.rotation;
    }
    void Update()
    {
        if (_target)
        {
            transform.LookAt(_target.transform);
        }
        else
        {
            transform.Rotate(_rotation * Time.deltaTime * speed);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterController>())
        {
            _target = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _target = null;
        gameObject.transform.rotation = startRot;
    }
}
