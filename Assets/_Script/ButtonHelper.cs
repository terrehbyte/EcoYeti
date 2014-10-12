using UnityEngine;
using System.Collections;

public class ButtonHelper : MonoBehaviour
{


    public bool LoadLevel(string LevelName)
    {
        Application.LoadLevel(LevelName);

        return false;
    }

    public bool ExitGame()
    {
        Application.Quit();
        return false;
    }
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
