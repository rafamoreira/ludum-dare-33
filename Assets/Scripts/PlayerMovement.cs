using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    float playerSpeed = 2;
    bool collidingL;
    bool collidingB;
    bool collidingR;
    bool collidingT;
    private Animator animator;


	// Use this for initialization
    void Awake()
    {
        animator = GetComponent<Animator>();
        ChangeAnimationState(0);
    }
    
    void Start () {
        collidingL = false;
        collidingB = false;
        collidingR = false;
        collidingT = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
            ChangeAnimationState(2);
        }

        if (Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            ChangeAnimationState(1);
        }

        if (Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
            ChangeAnimationState(4);
        }

        if (Input.GetKey("right"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
            ChangeAnimationState(3);
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

    }

    void ChangeAnimationState(int valeu)
    {
        animator.SetInteger("AnimState", valeu);
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
}
