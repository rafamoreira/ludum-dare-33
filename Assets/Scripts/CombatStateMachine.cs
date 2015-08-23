using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {

    public enum CombatStates { START, PLAYERCHOICE, ENEMYCHOICE, LOSE, WIN }

    public GameObject playerMenu;

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
            case (CombatStates.PLAYERCHOICE):
                StartPlayerChoiceRoutine();
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
        currentState = CombatStates.PLAYERCHOICE;
    }

    void StartPlayerChoiceRoutine()
    {
        Debug.Log("Player is choosing");
        playerMenu.SetActive(true);
    }
}
