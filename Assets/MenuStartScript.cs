using UnityEngine;
using System.Collections;

public class MenuStartScript : MonoBehaviour {

	public void LoadLevel(int levelID)
	{
		Application.LoadLevel (levelID);
	}

}