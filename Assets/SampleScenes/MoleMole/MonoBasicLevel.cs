using UnityEngine;
using UnityEngine.Networking;

using System.Collections;
using System.Collections.Generic;

/*
 *	
 *  Mono Basic Level
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
    public class MonoBasicLevel : NetworkBehaviour
    {

        public static LevelManager levelManager = null;

        void Awake()
        {
            levelManager = new LevelManager();
        }

		void Start ()
        {

		}
		
		void Update ()
        {
			//levelManager.Core();
		}
    }
}