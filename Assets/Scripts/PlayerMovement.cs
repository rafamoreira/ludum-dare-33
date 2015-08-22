using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    float playerSpeed = 2;
    bool collidingL;
    bool collidingB;
    bool collidingR;
    bool collidingT;

	// Use this for initialization
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
        }
        if (Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

    }
}
