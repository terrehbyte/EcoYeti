using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	bool paused = false;
	KeyCode pauseButton = KeyCode.Escape;
	public GameObject MainMenu;

	
	// Update is called once per frame
	void Update () {
	
				if (Input.GetKeyDown(pauseButton))
						paused = togglePause ();
		}

	bool togglePause()
	{
		if (Time.timeScale == 0f) {
						Time.timeScale = 1f;
						MainMenu.SetActive (false);
						return(false);
		} 
		else 
		{
			Time.timeScale = 0f;
			MainMenu.SetActive (true);
			return(true);
		}


	}
}
