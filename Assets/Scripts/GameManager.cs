using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public GameObject mainCamera;
    public GameObject battleCamera;

    // states to determine what is happening with the game
    // 0 the player is walking
    // 1 the player is in combat
    public int currentState;

	// Use this for initialization
	void Start () {
        currentState = 0;
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            currentState = 0;
            battleCamera.SetActive(false);
            mainCamera.SetActive(true);
        }
    }

    public void StartBattle()
    {
        currentState = 1;
        mainCamera.SetActive(false);
        battleCamera.SetActive(true);
    }
	
}
