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

        [ServerCallback]
        void Awake()
        {
            levelManager = new LevelManager();
        }

        [ServerCallback]
		void Start ()
        {

		}
		
        [ServerCallback]
		void Update ()
        {
			levelManager.Core();
		}
    }
}