using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {

    public enum CombatStates { START, PLAYERTURN, PLAYERCHOICE, ENEMYCHOICE, LOSE, WIN }

    public GameObject playerMenu;
    public GameObject playerFirstMenu;

    CombatStates currentState;

	// Use this for initialization
	void Start () {
        currentState = CombatStates.START;
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentState)
        {
            case (CombatStates.START):
                StartBattleRoutine();
                break;
            case (CombatStates.PLAYERTURN):
                StartPlayerTurnRoutine();
                break;
            case (CombatStates.PLAYERCHOICE):
                break;
            case (CombatStates.ENEMYCHOICE):
                break;
            case (CombatStates.LOSE):
                break;
            case (CombatStates.WIN):
                break;

        }

        Debug.Log(currentState);
	}

    void StartBattleRoutine()
    {
        Debug.Log("Start the battle");
        currentState = CombatStates.PLAYERTURN;
    }

    void StartPlayerTurnRoutine()
    {
        Debug.Log("Player is choosing");
        playerMenu.SetActive(true);
        playerFirstMenu.SetActive(true);
    }
}
