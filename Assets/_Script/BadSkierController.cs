using UnityEngine;
using System.Collections;

public class BadSkierController : MonoBehaviour {

	public float XVariance;
	public float SpeedModifier;
	public GameObject SoundTree;

	// Use this for initialization
	void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.tag == "TriggerZone") 
		{
			Debug.Log("switch! :)");
			Vector3 movement = new Vector3 (Random.Range (-XVariance, XVariance), 0.0f, 0.0f);
			Vector3 forceVector = movement * SpeedModifier;
			Debug.Log("Force!" + forceVector);
			rigidbody.AddForce (forceVector);
		}	
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

