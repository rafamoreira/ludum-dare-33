using UnityEngine;
using System.Collections;

public class Encounter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if (Grid.gameManager.currentState == 0)
            {
                Debug.Log("Starting battle");
                other.SendMessageUpwards("StopAnimation");
                Grid.gameManager.StartBattle();
            }
                
        }
    }
}
