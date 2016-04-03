using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 *	
 *  Basic Player
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
    public class BasicPlayer
    {
		private float speed = 30f;
		private GameObject _playerView;

        public BasicPlayer(GameObject playerObj)
        {
			_playerView = playerObj;
        }

		public void Core()
		{
			if (!_playerView.GetComponent<MonoNetController>().isMoving)
			{
				return;
			}

			float dx = 0f;
			float dz = 0f;

			float moveRadian = _playerView.GetComponent<MonoNetController>().GetCurrentAngle() * Mathf.Deg2Rad;
			float controllerRatioX = Mathf.Cos(moveRadian);
			float controllerRatioZ = Mathf.Sin(moveRadian);


			dx = controllerRatioX * Time.deltaTime * speed;
			dz = controllerRatioZ * Time.deltaTime * speed;

			_playerView.transform.position = new Vector3(_playerView.transform.position.x + dx, 0, _playerView.transform.position.z + dz);
			_playerView.transform.SyncPosition();
		}
    }
}