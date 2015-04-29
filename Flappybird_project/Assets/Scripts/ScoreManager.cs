using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour 
{
	public static int Score;
	public Text scoreText;
	// Use this for initialization

	void Start()
	{
		scoreText.text = "Score: 0";
	}
	void Update()
	{
		scoreText.text = "Score: " + Score.ToString ();
	}
}
