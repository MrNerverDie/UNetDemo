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
	public class LevelGeneralLogic : MonoBehaviour 
	{

		private static Queue<GameObject> _toCreatedPlayerObjQueue = new Queue<GameObject>();

		public static void EnqueueToCreatePlayerObj(GameObject playerObj)
		{
			_toCreatedPlayerObjQueue.Enqueue(playerObj);
		}

		public static bool IsAnyToCreatePlayerObj()
		{
			return _toCreatedPlayerObjQueue.Count != 0;
		}

		public static GameObject DequeueToCreatePlayerObj()
		{
			return _toCreatedPlayerObjQueue.Dequeue();
		}

	}
}
