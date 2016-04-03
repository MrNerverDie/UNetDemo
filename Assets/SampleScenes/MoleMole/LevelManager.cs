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
		private static DynamicObjectManager _dynamicObjectManager = null;

		public MonoBasicLevel basicLevel = null;

		public LevelManager()
		{
			_playerManager = new PlayerManager();
			_dynamicObjectManager = new DynamicObjectManager();
		}

		public void Core()
		{
			_playerManager.Core();
			_dynamicObjectManager.Core();
		}

		public DynamicObjectManager GetDynamicObjectManager()
		{
			return _dynamicObjectManager;
		}

		public IEnumerator CreateStone()
		{
			while(true)
			{
				float createX = Random.Range(-100f, 100f);
				float createZ = 100;
				Stone stone = _dynamicObjectManager.CreateStone(createX, createZ);


				yield return basicLevel.StartCoroutine(WaitSecondsWithPause(1f));
			}
			
		}

		public IEnumerator WaitSecondsWithPause(float t)
		{
			float timer = 0f;

			do
			{
				timer += Time.deltaTime;

				yield return null;
			} while (timer < t);
		}

	}
}