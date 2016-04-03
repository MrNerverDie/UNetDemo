using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

/*
 *	
 *  DynamicObjectManger
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
    public class DynamicObjectData
    {
        public const int STONE_TYPE = 1;

        private static readonly string[] RESOURCE_PATH = new string[]
        {
            "",
            "Prefabs/BigAsteroid",
        };

        public static string GetResourcePath(int type)
        {
            return RESOURCE_PATH[type];
        }
    }

    public class DynamicObjectManager
    {
		private List<BaseDynamicObject> _dynamicObjectList = new List<BaseDynamicObject>();


        public DynamicObjectManager()
        {

        }
       
        public void Core()
        {
			for (int i = 0; i < _dynamicObjectList.Count; i++)
			{
				if (_dynamicObjectList[i].IsToBeDestroy())
				{
					_dynamicObjectList[i].Destroy();
					_dynamicObjectList.RemoveAt(i);
					i--;
				}
			}

			for (int i = 0; i < _dynamicObjectList.Count; i++)
			{
				_dynamicObjectList[i].Core();
			}
        } 

        public Stone CreateStone(float createX, float createZ)
        {
			//	//
			GameObject prefab = Resources.Load<GameObject>(DynamicObjectData.GetResourcePath(DynamicObjectData.STONE_TYPE));
			ClientScene.RegisterPrefab(prefab);

			GameObject dynamicObjectView = GameObject.Instantiate(prefab) as GameObject;
			Stone stone = new Stone(dynamicObjectView, DynamicObjectData.STONE_TYPE, createX, createZ);
			_dynamicObjectList.Add(stone);

			NetworkServer.Spawn(dynamicObjectView);
			return stone;
        }
    }
}