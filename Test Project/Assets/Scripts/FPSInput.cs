using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = -9.8f;
    public float jumpValue = 5;
    private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;

        /*
        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded)
        {
            movement.y -= gravity*5;
        }*/

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _characterController.Move(movement);
       
    }
}
