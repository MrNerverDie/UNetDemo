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
		public static GameObject abcde;

        public static LevelManager levelManager = new LevelManager();

        void Awake()
        {

        }

		void Start ()
        {

		}
		
		void Update ()
        {
			levelManager.Core();
		}
    }
}