using UnityEngine;
//using System.Collections;
using System;

public class rWalking : MonoBehaviour
{
    Animator animator;

    public float moveSpeed = 100f;

    float vertical = 0;
    float horizontal = 0;

    //animation states - the values in the animator conditions
    const int CHAR_STAND = 0;
    const int CHAR_RIGHT = 1;
    const int CHAR_LEFT = 2;
    const int CHAR_FOR = 3;
    const int CHAR_BACK = 4;

    int _currentAnimationState = CHAR_STAND;

    void Start()
    {
        //define the animator attached to the player
        animator = this.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        vertical  = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        //Moves Forward and back along z axis //Up/Down
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * vertical * moveSpeed);
        //Moves Left and right along x Axis //Left/Right
        transform.Translate(Vector3.right * Time.deltaTime * horizontal * moveSpeed);

        if (Math.Abs(vertical) < 0.7 && Math.Abs(horizontal) < 0.7)
            changeState(CHAR_STAND);
        else if (vertical > 0)
            changeState(CHAR_BACK);
        else if (vertical < 0)
            changeState(CHAR_FOR);
        else if (horizontal > 0)
            changeState(CHAR_RIGHT);
        else if (horizontal < 0)
            changeState(CHAR_LEFT);
    }

    void changeState(int state){
 
        if (_currentAnimationState == state)
        return;
 
        switch (state) {
 
        case CHAR_RIGHT:
            animator.SetInteger ("state", CHAR_RIGHT);
            break;
 
        case CHAR_LEFT:
            animator.SetInteger ("state", CHAR_LEFT);
            break;
 
        case CHAR_FOR:
            animator.SetInteger ("state", CHAR_FOR);
            break;
 
        case CHAR_BACK:
            animator.SetInteger ("state", CHAR_BACK);
            break;
 
        case CHAR_STAND:
            animator.SetInteger ("state", CHAR_STAND);
            break;
 
        }
 
        _currentAnimationState = state;
    }
} 
