using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerControllers : MonoBehaviour {

    public float speed = 6.0F;
    public float jumpValue = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
       
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = Vector3.ClampMagnitude(moveDirection, speed);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

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

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpValue;
            }
        }            
        moveDirection.y -= gravity * Time.deltaTime; 
        controller.Move(moveDirection * Time.deltaTime);
    }
}
