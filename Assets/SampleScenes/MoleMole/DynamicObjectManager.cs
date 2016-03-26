using UnityEngine;
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
        public const int STONE_TYPE = 0;

        private static readonly string[] RESOURCE_PATH = new string[]
        {
            "",
            "SampleScenes/Prefabs/BigAsteroid",
        };

        public string GetResourcePath(int type)
        {
            return RESOURCE_PATH[type];
        }
    }

    public class DynamicObjectManager
    {

        public DynamicObjectManager()
        {

        }
       
        private void Core()
        {

        } 

        public void CreateStone()
        {

        }
    }
}