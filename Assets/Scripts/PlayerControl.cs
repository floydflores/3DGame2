using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{   
    #region Variables
    private int count;

    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float gravity = 20f;

    public CharacterController controller;
    public Vector3 moveDirection = Vector3.zero;
    
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        count = 0;
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement = transform.TransformDirection(movement);
        movement *= moveSpeed;

        if (controller.isGrounded)
        {
            moveDirection = movement;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }
    
        else
        {
        moveDirection.y -= gravity * Time.deltaTime;
        }

        controller.Move(moveDirection * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"));
        {
            other.gameObject.SetActive(false);
            FindObjectOfType<GameManager>().UpdateScore(1);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }   
    
    }
    

}
