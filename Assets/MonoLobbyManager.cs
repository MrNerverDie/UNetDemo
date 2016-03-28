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
		GameObject abc;


		public override bool OnLobbyServerSceneLoadedForPlayer(GameObject lobbyPlayer, GameObject gamePlayer)
		{
			Debug.Log("A0");
			Debug.Log(gamePlayer.name + " " + MonoBasicLevel.levelManager);
			MonoBasicLevel.levelManager.AddPlayer(gamePlayer);
			abc = gamePlayer;
			MonoBasicLevel.abcde = gamePlayer;
			Debug.Log("A1");
			return true;
		}

		//public override GameObject OnLobbyServerCreateGamePlayer(NetworkConnection conn, short playerControllerId)
		//{
		//	GameObject myPlayer = Instantiate(gamePlayerPrefab, new Vector3(Random.value * 10, 0, 0), Quaternion.identity) as GameObject;
		//	MonoBasicLevel.levelManager.AddPlayer(myPlayer);
		//	return myPlayer;
		//}
	}
}