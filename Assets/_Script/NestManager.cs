using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NestManager : MonoBehaviour {

	public BirdNest[] Nests;
	public int EggCount = 15;
	public Text eggCountText;

	void Start ()
	{
		SetCountText ();
	}

	public void SetCountText ()
	{
		eggCountText.text = "Eggs Left: " + EggCount.ToString ();
	}
}
