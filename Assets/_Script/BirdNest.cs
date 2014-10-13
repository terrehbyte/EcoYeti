using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class BirdNest : MonoBehaviour {

	public List<GameObject> Eggs = new List<GameObject> ();
	public GameObject EggCrushSoundObject;
	public NestManager MainManager;

	public float nestHealth = 3;
	public float invulTime = 3;




	void OnTriggerEnter(Collider other)
	{
				/*nestHealth -= 1;
				lastCollisionTime = DateTime.Now.Second;
				if (nestHealth == 2) {
						bool Eggs = false;
				} else if (nestHealth == 1) {	
						bool Eggs = false;
				} else if (nestHealth == 0) {
						bool Eggs = false;
				}*/
        if (other.gameObject.tag == "Skier")
        { 
		    for (int i =0; i < Eggs.Count; i++)
		    {
			    if (Eggs[i])
			    {
					Quaternion SpawnRotation = new Quaternion();
					Vector3 SpawnLocation = new Vector3(0,0,0);
					Instantiate (EggCrushSoundObject, SpawnLocation, SpawnRotation);
				    Destroy(Eggs[i]);
					MainManager.EggCount--;
					MainManager.SetCountText();

					if (MainManager.EggCount <= 0)
					{
						Application.LoadLevel (3);
					}

				    break;
			    }
		    }
        }
	}


}
