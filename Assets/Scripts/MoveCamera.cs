using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5.0f;
    [SerializeField] float rotationSpeed = 2.0f;
    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");  
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the camera based on the input
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
        // Get mouse input for rotation
        float mouseX = Input.GetAxis("Mouse X");

        // Rotate the camera based on the mouse input
        transform.Rotate(Vector3.up, mouseX * rotationSpeed);

        }


    }
}
