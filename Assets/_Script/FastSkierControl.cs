using UnityEngine;
using System.Collections;

public class FastSkierControl : MonoBehaviour {
	
	public int MovementMultiplier;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Vector3 movement = new Vector3 (0.0f, 0.0f, -1.0f);
		rigidbody.AddForce (movement*MovementMultiplier);
	}
}
