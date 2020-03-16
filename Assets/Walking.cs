using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public float moveSpeed = 150f;
    public new Vector3 fixVector = new Vector3(0, 0, 0);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveCharacter(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
            
    }

    void OnTriggerEnter(Collider collision)
    {
        //moveSpeed *= -1;
        //moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        print("Collided!");
        //moveSpeed *= -1;
    }

    void moveCharacter(Vector3 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
} 