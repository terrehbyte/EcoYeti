using UnityEngine;
using System;
using System.Collections.Generic;

public class BirdNest : MonoBehaviour {

	public List<GameObject> Eggs = new List<GameObject> ();
	public GameObject EggCrushSoundObject;

	public float nestHealth = 3;
	public float invulTime = 3;

	void OnCollisionEnter(Collision other)
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
				    break;
			    }
		    }
        }
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
