using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
//Assassins creed 2 ost jesper kyd, Etsio family
//trevor morris main theme dragn age inquisition, Hans zimmer cornfield search
//Aliens unkown artist
//carbon based lifeforms

public class GameManager : MonoBehaviour {

	public static GameManager Instance;
	//Text does not like being turned on and of, only set values.
	//GameObjects can be set on and off, e.g other game objects.
	public Text scoreText;

	public GameObject gameOverScreen;

	// private int score = 0;
	private int score2 = 0;

	public float meteorSpeed = -2f;

	public bool isGameOver = false;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		if (Instance != null)
		{
			Destroy(gameObject);
		} else
		{
			Instance = this;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.Instance.isGameOver && 	Input.GetButton("Jump"))
		{
			// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			SceneManager.LoadScene("Space");
			return;
		}
		score2 = Convert.ToInt32(Time.timeSinceLevelLoad);
		scoreText.text = "SCORE : "+ score2.ToString();
		// // Debug.Log("Modulo :" + (score2 % 10));
		// if (score2 != 0 && score2 % 10 == 0)
		// {
		// 	meteorSpeed += 2;
		// 	// Debug.Log(score2 + " is a multiple of 10");	
		// }
		
	}

	public void SetScore ()
	{
		// score++;
		// scoreText.text = "SCORE : "+ score.ToString();
		// meteorSpeed += score / -50f;
	}

	public void PlayerDied () 
	{
		gameOverScreen.SetActive(true);
		isGameOver = true;
	}

	public void SetMeteorSpeed ()
	{
		meteorSpeed += score2 / -50f;
	}
}
