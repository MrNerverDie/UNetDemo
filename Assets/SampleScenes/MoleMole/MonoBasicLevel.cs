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

        public static LevelManager levelManager;

        void Awake()
        {
			levelManager = new LevelManager();
			levelManager.basicLevel = this;
        }

		void Start ()
        {
			StartCoroutine(CreateStone());
		}
		
		void Update ()
        {
			levelManager.Core();
		}

		public IEnumerator CreateStone()
		{
			while (true)
			{
				float createX = Random.Range(-100f, 100f);
				float createZ = 100;
				Stone stone = levelManager.GetDynamicObjectManager().CreateStone(createX, createZ);


				yield return StartCoroutine(WaitSecondsWithPause(1f));
			}

		}

		public IEnumerator WaitSecondsWithPause(float t)
		{
			float timer = 0f;

			do
			{
				timer += Time.deltaTime;

				yield return null;
			} while (timer < t);
		}
    }
}