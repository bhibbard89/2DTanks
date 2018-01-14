using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public GameObject EndPanel;

	public Text winnerText;

	int winner;


	void Start () {
		EndPanel.SetActive (false);
	}




	public void Retry()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void Player1Won()
	{
		winnerText.text = "Player 1 won!";
		EndPanel.SetActive (true);
	}

	public void Player2Won()
	{
		winnerText.text = "Player 2 won!";
		EndPanel.SetActive (true);
	}


}
