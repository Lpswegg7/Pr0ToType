/*
 * using UnityEngine;
using System.Collections;

/**
 * The character base class.
 */ 
/*public class Character : MonoBehaviour {

	/**
	 * The types of attacks characters can do.
	 */
/*	public enum AttackType
	{
		/** The default attack, everyone has this. */
//		DEFAULT
//	}
	
	/**
	 * Character stats.
	 */
/*	public enum Stat
	{
		/** Attack priority. */
//		AGILITY,
		/** The character's HP. */
//		HEALTH,
		/** The strength of a character's magic. */
//		MAGIC,
		/** The character's defense ability. */
//		STAMINA,
		/** The character's attack ability. */
//		STRENGTH
//	}
	
	/**
	 * Attack results.
	 */
/*	public interface IAttackCallbacks
	{
	}
	
	/**
	 * Defend results.
	 */
/*	public interface IDefendCallbacks
	{
	}
	
	/**
	 * The character's class.
	 */
/*	private CharacterClass mCharacterClass;
	
	/**
	 * The character's stats.
	 */
/*	private Map<Character.Stat, Float> mStats;
	
	/**
	 * Constructor.
	 */
/*	public Character()
	{
		mCharacterClass = new CharacterClass();
		mStats = new HashMap<Character.Stat, Float>();
		for (Character.Stat stat : Character.Stat.values())
		{
			this.setStat(stat, 0.0f);
		}
	}
	
	// Accessors
	
	/**
	 * Get the character's class.
	 * @return Character class.
	 */
/*	public CharacterClass getCharacterClass() { return mCharacterClass; }
	
	/**
	 * Get the value of a specific stat.
	 * @param stat The stat to acquire.
	 * @return Character stat.
	 */
/*	public float getStat(Character.Stat stat) { return mStats.get(stat).floatValue(); }
	
	
	// Mutators
	
	/**
	 * Set the character's class.
	 * @param characterClass Character class.
	 */
/*	public void setCharacterClass(CharacterClass characterClass)
	{
		if (characterClass != null)
		{
			mCharacterClass = characterClass;
		}
	}
	
	/**
	 * Set the value of a specific stat. Always filtered for correctness.
	 * @param The stat to set.
	 * @param val The desired stat value.
	 */
/*	public void setStat(Character.Stat stat, float val)
	{
		setStat(stat, val, true);
	}
	
	/**
	 * Set the value of a specific stat.
	 * @param The stat to set.
	 * @param val The desired stat value.
	 * @param filter Whether or not the CharacterClass should filter the stat for correctness.
	 */
/*	protected void setStat(Character.Stat stat, float val, boolean filter)
	{
		if (filter == true)
		{
			mCharacterClass.filterAndSetStat(this, stat, val);
		}
		else
		{
			mStats.put(stat, new Float(val));
		}
	}
	
	// Commands
	
	/**
	 * Attack.
	 * @param adversary The character to attack.
	 * @param attackType The type of attack to execute.
	 * @param callbacks The attack results
	 */
/*	public void attack(Character adversary, AttackType attackType, IAttackCallbacks callbacks)
	{
		// TODO
	}
	
	/**
	 * Defend.
	 * @param The defend results.
	 */
/*	public void defend(IDefendCallbacks callbacks)
	{
		// TODO
	}
}
*/