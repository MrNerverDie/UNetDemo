using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 *	
 *  Manage Level State
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
	public class LevelManager
	{

		private static PlayerManager _playerManager = null;

		public LevelManager()
		{
			_playerManager = new PlayerManager();
		}

		public void Core()
		{
			_playerManager.Core();
		}

		public void AddPlayer(GameObject playerObj)
		{
			_playerManager.AddPlayer(playerObj);
		}
	}
}