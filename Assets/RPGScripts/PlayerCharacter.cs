/*
using UnityEngine;
using System.Collections;

/**
 * The class representing the player's character.
 */
/*public class PlayerCharacter : Character {

	/**
	 * Notifies the success/failure of an attempt to add a player familiar.
	 */
/*	public interface IAddPlayerFamiliarCallback
	{
		/**
		 * Called when the operation completes.
		 * @param error Was there an error while trying to add a familiar. error == null means no error.
		 */
/*		public void onCompletion(Error error);
	}
	
	/**
	 * Notifies the success/failure of an attempt to remove a player familiar.
	 */
/*	public interface IRemovePlayerFamiliarCallback
	{
		/**
		 * Called when the operation completes.
		 * @param error Was there an error while trying to remove a familiar. error == null means no error.
		 */
/*		public void onCompletion(Error error);
	}
	
	/**
	 * The maximum number of familiars a character can have.
	 */
/*	public static final int MAX_PLAYER_FAMILIAR_COUNT = 2;
	
	/**
	 * Slots for the plaer's familiars. MAX_PLAYER_FAMILIAR_COUNT slots.
	 */
/*	private PlayerFamiliar[] mPlayerFamiliars;
	
	/**
	 * The constructor.
	 */
/*	public PlayerCharacter()
	{
		mPlayerFamiliars = new PlayerFamiliar[MAX_PLAYER_FAMILIAR_COUNT];
		for (int i = 0; i < MAX_PLAYER_FAMILIAR_COUNT; i++)
		{
			mPlayerFamiliars[i] = null;
		}
	}
	
	/**
	 * Add a player familiar.
	 * @param The player familiar to add.
	 * @param The result callback.
	 */
/*	public void addPlayerFamiliar(PlayerFamiliar playerFamiliar, IAddPlayerFamiliarCallback callback)
	{
		if (playerFamiliar != null)
		{
			boolean alreadyAdded = false;
			for (int i = 0; i < mPlayerFamiliars.length; i++)
			{
				if (mPlayerFamiliars[i] != null)
				{
					if (mPlayerFamiliars[i].equals(playerFamiliar))
					{
						alreadyAdded = true;
						break;
					}
				}
			}
			if (alreadyAdded == false)
			{
				boolean added = false;
				for (int i = 0; i < mPlayerFamiliars.length; i++)
				{
					if (mPlayerFamiliars[i] == null)
					{
						mPlayerFamiliars[i] = playerFamiliar;
						added = true;
						break;
					}
				}
				if (callback != null)
				{
					if (added == true)
					{
						callback.onCompletion(null);
					}
					else
					{
						callback.onCompletion(new Error("The PlayerFamiliar could not be added due to lack of slots."));
					}
				}
			}
			else
			{
				if (callback != null)
				{
					callback.onCompletion(new Error("The PlayerFamiliar has already been added."));
				}
			}
		}
		else
		{
			if (callback != null)
			{
				callback.onCompletion(new Error("PlayerFamiliar parameter is null."));
			}
		}
	}
	
	/**
	 * Gets the player's familiars.
	 * @return A list of familiars.
	 */
/*	public List<PlayerFamiliar> getPlayerFamiliars()
	{
		List<PlayerFamiliar> lst = new ArrayList<PlayerFamiliar>();
		for (int i = 0; i < mPlayerFamiliars.length; i++)
		{
			if (mPlayerFamiliars[i] != null)
			{
				lst.add(mPlayerFamiliars[i]);
			}
		}
		return lst;
	}
	
	/**
	 * Removes a familiar from a player's party.
	 * @param playerFamiliar The player familiar to remove.
	 * @param callback The result callback.
	 */
/*	public void removePlayerFamilar(PlayerFamiliar playerFamiliar, IRemovePlayerFamiliarCallback callback)
	{
		boolean found = false;
		for (int i = 0; i < mPlayerFamiliars.length; i++)
		{
			if (mPlayerFamiliars[i] != null && mPlayerFamiliars[i].equals(playerFamiliar))
			{
				mPlayerFamiliars[i] = null;
				found = true;
				break;
			}
		}
		if (callback != null)
		{
			if (found)
			{
				callback.onCompletion(null);
			}
			else {
				callback.onCompletion(new Error("PlayerFamiliar was not fonud so, obviously, it was not removed."));
			}
		}
		
	}
}
*/