using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

using UnityStandardAssets.Network;


/*
 *  
 *  Mono Lobby Manager
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
			Debug.Log(gamePlayer.name + " " + MonoBasicLevel.levelManager);
			return true;
		}

		//public override GameObject OnLobbyServerCreateGamePlayer(NetworkConnection conn, short playerControllerId)
		//{
		//	GameObject myPlayer = Instantiate(gamePlayerPrefab, Vector3.zero, Quaternion.identity) as GameObject;
		//	MonoBasicLevel.levelManager.AddPlayer(myPlayer);
		//	return myPlayer;
		//}
	}
}