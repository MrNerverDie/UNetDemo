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
	public static class TransformExtension 
	{

		public static void SyncPosition(this Transform transform)
		{
			transform.GetComponent<MonoNetTransform>().targetPos = new Vector2(transform.position.x, transform.position.z);
		}

	}
}
