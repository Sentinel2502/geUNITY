using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rWalking : MonoBehaviour
{
    public float speed = 150f;
    public Rigidbody rb; 
    public Vector3 movement;

    void Start ()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            movement = new Vector3(0, 0, -1);
            //rb.MovePosition(transform.position + (speed * Time.deltaTime * new Vector3(0, 0, -1)));
        if (Input.GetKey(KeyCode.A))
            movement = new Vector3(0, 0, 1);
            //rb.MovePosition(transform.position + (speed * Time.deltaTime * new Vector3(0, 0, 1)));
        if (Input.GetKey(KeyCode.W))
            movement = new Vector3(1, 0, 0);
            //rb.MovePosition(transform.position + (speed * Time.deltaTime * new Vector3(1, 0, 0)));
        if (Input.GetKey(KeyCode.S))
            movement = new Vector3(-1, 0, 0);
            //rb.MovePosition(transform.position + (speed * Time.deltaTime * new Vector3(-1, 0, 0)));
    }

    void FixedUpdate()
    {
        MoveCharacter(movement);
        movement = new Vector3(0, 0, 0);
    }

    void MoveCharacter(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }
}