using UnityEngine;

public class Collision : MonoBehaviour
{

    public Walking walk;

    private void Start()
    {
        
    }

    void Update()
    {
        
    }

   void OnTriggerEnter(Collider other)
    {   
       walk.moveSpeed = walk.moveSpeed * -1;
    }

   void OnTriggerStay(Collider other)
    {   

    }

    void OnTriggerExit(Collider other)
    {
        //moveSpeed = 500f;
    }
}