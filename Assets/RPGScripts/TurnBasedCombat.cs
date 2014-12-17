/*
 * using UnityEngine;
using System.Collections;

public class TurnBasedCombat : MonoBehaviour 
{
	
	public enum BattleStates
	{
		START,
		PLAYERCHOICE,
		CALCMDAMAGE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}
	
	private BattleStates currentState;
	
	
	// Use this for initialization
	void Start () 
	{
		currentState = BattleStates.START;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//DISPLAY CURRENT STATE
		Debug.Log (currentState);
		switch (currentState) 
		{
		case (BattleStates.START):
			//SETUP BATTLE FUNCTION
			//create enemy
			//choose who goes first based on agility
			ChooseWhoGoesFirst ();
			break;
		case (BattleStates.PLAYERCHOICE):  //player chooses the ability they want to use
			break;
		case (BattleStates.ENEMYCHOICE):
			//coded AI goes here
			//enemyDidCompleteTurn = true;
			//CheckWhoGoesNext();
			break;
		case (BattleStates.CALCMDAMAGE):  //we calculate damage done by player, look for exisiting status effects and add that damage
			break;
		case (BattleStates.LOSE):
			break;
		case (BattleStates.WIN):
			break;
			
		}
	}

	private void ChooseWhoGoesFirst()
	{
		if (PlayerCharacter.Agility >= Enemy.Agility) {
			//player goes first
			currentState = BattleStates.PLAYERCHOICE;
		}
		if (PlayerCharacter.Agility < Enemy.Agility) {
			//enemy is going to go first
			currentState = BattleStates.ENEMYCHOICE;
		}
		//if (GameInformation.Agility == newEnemy.Agility) {
		//    CAN DECIDE IF I WANT THIS LATER
		//		}
	}
	
	void OnGUI()
	{
		if (GUILayout.Button("NEXT STATE")) 
		{
			if(currentState==BattleStates.START)
			{
				currentState = BattleStates.PLAYERCHOICE;
			}
			
			else if(currentState==BattleStates.PLAYERCHOICE)
			{
				currentState = BattleStates.ENEMYCHOICE;
			}
			
			else if(currentState==BattleStates.ENEMYCHOICE)
			{
				currentState = BattleStates.LOSE;
			}
			
			else if(currentState==BattleStates.LOSE)
			{
				currentState = BattleStates.WIN;
			}
			
			else if(currentState==BattleStates.WIN)
			{
				currentState = BattleStates.START;
			}
		}
	}
}
*/
