using UnityEngine;
using UnityEngine.Networking;
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
	public class MonoNetController : NetworkBehaviour 
	{
		[SyncVar]
		public float currentAngle = 0;
		[SyncVar]
		public bool isMoving = false;

		[ClientCallback]
		void Update()
		{
			if (!isLocalPlayer)
				return;

			float inputX = 0;
			float inputY = 0;
			if (Input.GetKey(KeyCode.W))
			{
				inputY = 1f;
			}
			else if (Input.GetKey(KeyCode.S))
			{
				inputY = -1f;
			}
			else if (Input.GetKey(KeyCode.A))
			{
				inputX = -1f;
			}
			else if (Input.GetKey(KeyCode.D))
			{
				inputX = 1f;
			}

			CmdMove(inputX, inputY);
		}

		[Command]
		public void CmdMove(float inputX, float inputY)
		{
			if (inputX == 0 && inputY == 0)
			{
				isMoving = false;
			}
			else
			{
				isMoving = true;
				if (inputX > 0 && inputY > 0)
				{
					currentAngle = -45f;
				}
				else if (inputX > 0 && inputY < 0)
				{
					currentAngle = -135f;
				}
				else if (inputX > 0 && inputY == 0)
				{
					currentAngle = -90f;
				}
				else if (inputX < 0 && inputY > 0)
				{
					currentAngle = 45f;
				}
				else if (inputX < 0 && inputY < 0)
				{
					currentAngle = -225f;
				}
				else if (inputX < 0 && inputY == 0)
				{
					currentAngle = -270f;
				}
				else if (inputX == 0 && inputY > 0)
				{
					currentAngle = 0f;
				}
				else if (inputX == 0 && inputY < 0)
				{
					currentAngle = -180f;
				}
			}
		}

		public float GetCurrentAngle()
		{
			return currentAngle + 90;
		}
	}
}
