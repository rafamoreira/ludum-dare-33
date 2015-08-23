using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    float playerSpeed = 2;
    Animator animator;


	// Use this for initialization
    void Awake()
    {
        animator = GetComponent<Animator>();
        ChangeAnimationState(0);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if(Grid.gameManager.currentState == 0)
            Movement();
        
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

    }

    void Movement()
    {
        if (Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
            ChangeAnimationState(2);
        }
        else if (Input.GetKeyUp("up"))
            ChangeAnimationState(5);

        if (Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            ChangeAnimationState(1);
        }
        else if (Input.GetKeyUp("down"))
            ChangeAnimationState(0);

        if (Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
            ChangeAnimationState(4);
        }
        else if (Input.GetKeyUp("left"))
            ChangeAnimationState(7);

        if (Input.GetKey("right"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
            ChangeAnimationState(3);
        }
        else if (Input.GetKeyUp("right"))
            ChangeAnimationState(6);
    }

    void ChangeAnimationState(int value)
    {
        animator.SetInteger("AnimState", value);
        /* 0 - Idle
         * 1 - Front
         * 2 - Back
         * 3 - Right
         * 4 - Left
         * 5 - Idle Back
         * 6 - Idle Right
         * 7 - Idle left 
         */
    }

    public void StopAnimation()
    {
        animator.SetInteger("AnimState", 0);
    }


}
