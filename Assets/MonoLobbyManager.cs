using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityStandardAssets.Network;


/*
 *  
 *  
 *
 *  by Xuanyi
 *
 */

namespace MoleMole
{
    public class MonoLobbyManager : LobbyManager
    {
		public override bool OnLobbyServerSceneLoadedForPlayer(GameObject lobbyPlayer, GameObject gamePlayer)
		{
			Debug.Log(client);
			MonoBasicLevel.levelManager.AddPlayer(gamePlayer);
			return base.OnLobbyServerSceneLoadedForPlayer(lobbyPlayer, gamePlayer);
		}
	}
}