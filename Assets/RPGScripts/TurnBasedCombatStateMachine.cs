/*
using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

	public enum BattleStates
	{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		ATTACKRESULT,
		LOSE,
		WIN
	}

	private BattleStates currentState;

	private void Awake()
	{
		currentState = BattleStates.START;
	}

	// Use this for initialization
	void Start () 
	{
		DetermineFirstAttacker ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void DetermineFirstAttacker()
	{
		if (PlayerCharacter.Agility >= Enemy.Agility) {
			//player goes first
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE;
		}
		if (PlayerCharacter.Agility < Enemy.Agility) {
			//enemy is going to go first
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE;
		}
	}
}
*/