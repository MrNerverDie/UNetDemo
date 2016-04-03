using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

/*
 *  
 *  
 *
 *  by Xuanyi
 *
 */

namespace MoleMole
{
    public class BaseDynamicObject
    {
		/*	DynamicObj View	*/
		protected GameObject _dynamicObjView;
		protected Transform _dynamicObjTransform;

		/*	DynamicObj Type */
		protected int _typeID;

		public BaseDynamicObject()
		{
			
		}



		/*	Constructor		*/
		public virtual void Init(GameObject dynamicObjView, int typeID, float bornX, float bornZ)
		{

			_dynamicObjView = dynamicObjView;
			_dynamicObjTransform = _dynamicObjView.transform;
			_dynamicObjTransform.position = new Vector3(bornX, 0, bornZ);

			_typeID = typeID;

			return;
		}

        public virtual void Core()
        {
			UpdateState();
			UpdateAnimation();
        }

		public virtual void Destroy()
		{
			NetworkServer.Destroy(_dynamicObjView);
		}

		public virtual bool IsToBeDestroy()
		{
			return false;
		}

		public virtual void UpdateState()
		{

		}

		public virtual void UpdateAnimation()
		{

		}
    }
}