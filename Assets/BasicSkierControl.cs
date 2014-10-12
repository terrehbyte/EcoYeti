using UnityEngine;
using System.Collections;

public class BasicSkierControl : MonoBehaviour {

	public GameObject SoundTree;

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Tree") {
			Quaternion SpawnRotation = new Quaternion ();
			Vector3 SpawnLocation = new Vector3 (0, 0, 0);
			Instantiate (SoundTree, SpawnLocation, SpawnRotation);
		} 
		
		
	}
}
