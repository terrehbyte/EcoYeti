using UnityEngine;
using System.Collections;

public class FastSkierControl : MonoBehaviour
{
	
	public int MovementMultiplier;
	public GameObject SoundTree;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Vector3 movement = new Vector3 (0.0f, 0.0f, -1.0f);
		GetComponent<Rigidbody>().AddForce (movement*MovementMultiplier);
	}


	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Tree") {
			Quaternion SpawnRotation = new Quaternion ();
			Vector3 SpawnLocation = new Vector3 (0, 0, 0);
			Instantiate (SoundTree, SpawnLocation, SpawnRotation);
		} 
		
		
	}
}
