using UnityEngine;
using System.Collections;

public class DestroyAtBottom : MonoBehaviour {

	void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.tag == "DeathZone") 
		{
			Debug.Log("Kill time");
			Destroy (gameObject);
		}	
	} 
}



