using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
	{
		Application.Quit();
		Debug.Log("The game is dead");
	}
}
