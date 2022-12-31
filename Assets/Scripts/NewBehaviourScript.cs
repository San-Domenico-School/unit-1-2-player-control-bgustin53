using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private float speed;            // holds the forward movement of the vehicle
    private float turnSpeed;        // holds the turn speed of the vehicle
    private float moveInput;        // gets a value [-1, 1] from vertical input manager
    private float turnInput;        // gets a value [-1, 1] from horizontal input manager

    // Initializes speed and turnSpeed before the first frame update
    void Start()
    {
        speed = 20.0f;
        turnSpeed = 30.0f;
    }

    // Update is called once per frame
    void Update()
    {
        CheckForInput();
        MoveVehicle();
    }

    // Moves and turns the vehicle based one user inputs
    private void MoveVehicle()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * turnInput);
        transform.Rotate(Vector3.back * Time.deltaTime * turnSpeed * turnInput);
    }

    // Sets move and turn inputs from default Input Manager
    private void CheckForInput()
    {
        moveInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }
}
