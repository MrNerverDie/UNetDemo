using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

/*
 *  
 *  Mono Net Transform
 *
 *  by Xuanyi
 *
 */

namespace MoleMole
{
	public class SyncListVector2 : SyncListStruct<Vector2>
	{

	}

    public class MonoNetTransform : NetworkBehaviour
    {
		[SyncVar]
		public float speed = 30f;
		[SyncVar]
		public Vector2 targetPos;

		[ClientCallback]
        void Update () 
        {
			Vector3 moveDelta = new Vector3(targetPos.x - transform.position.x, 0, targetPos.y - transform.position.z);

			if (!IsReachTarget())
			{
				Vector3 moveDelataThisFrame = moveDelta.normalized * speed * Time.deltaTime;
				if (moveDelataThisFrame.magnitude > moveDelta.magnitude)
				{
					moveDelataThisFrame = moveDelta;
				}
				transform.Translate(moveDelataThisFrame);
			}
        }

		private bool IsReachTarget()
		{
			return Mathf.Approximately(targetPos.x, transform.position.x) && Mathf.Approximately(targetPos.y, transform.position.z);
		}
    }
}