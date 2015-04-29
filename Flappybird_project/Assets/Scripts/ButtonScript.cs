using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour 
{

	public void LoadScene( string aSceneName )
	{
		Application.LoadLevel (aSceneName);
		ScoreManager.Score = 0;
	}

	public void Exit()
	{
		Debug.Log ("SLUUTA");
		Application.Quit ();
	}
}
