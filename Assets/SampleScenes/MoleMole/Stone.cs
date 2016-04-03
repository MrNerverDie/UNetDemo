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
    public class Stone : BaseDynamicObject
    {
		private float speed = 30f;

		public Stone(GameObject dynamicObjView, int typeID, float createX, float createZ)
		{
			Init(dynamicObjView, typeID, createX, createZ);
			InitNetwork();
		}

		public override void UpdateState()
		{
			_dynamicObjTransform.Translate(new Vector3(0, 0, -Time.deltaTime * speed));
			_dynamicObjTransform.SyncPosition();
		}

		public override bool IsToBeDestroy()
		{
			return _dynamicObjTransform.position.z < -100f;
		}

		public void InitNetwork()
		{
			_dynamicObjTransform.GetComponent<MonoNetTransform>().speed = speed;
		}

    }
}