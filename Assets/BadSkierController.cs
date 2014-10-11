using UnityEngine;
using System.Collections;

public class BadSkierController : MonoBehaviour {

	public float XVariance;
	public float SpeedModifier;


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
		
	}


