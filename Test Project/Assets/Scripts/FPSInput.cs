using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = 9.8f;
    public float jumpValue = 5;

    private CharacterController _characterController;
    private Rigidbody _rigidbody;

    private Vector3 movement = Vector3.zero;
    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement = transform.TransformDirection(movement);

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            speed *= 2;
            Debug.Log("Контрол зажат" + speed);
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed /= 2;
            Debug.Log("Контрол отжат" + speed);
        }

        if (Input.GetKey(KeyCode.Space)  && _characterController.isGrounded)
        {
            movement.y = jumpValue;
            Debug.Log("Прыжок" + jumpValue);
        }

        movement *= Time.deltaTime;
        movement.y -= gravity * Time.deltaTime;
        _characterController.Move(movement);
       
    }
}
