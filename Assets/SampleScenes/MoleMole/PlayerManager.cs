using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 *	
 *  
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
    public class PlayerManager
    {
        private List<BasicPlayer> _playerList = new List<BasicPlayer>();

        public PlayerManager()
        {

        }

        public void Core()
        {
			foreach (var player in _playerList)
			{
				player.Core();
			}
        }

        public void Destroy()
        {

        }

		public void AddPlayer(GameObject playerObj)
		{
			_playerList.Add(new BasicPlayer(playerObj));
		}
    }
}