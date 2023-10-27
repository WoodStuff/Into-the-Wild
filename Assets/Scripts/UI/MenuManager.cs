using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	public enum Menus
	{
		Main,
		Chapters,
	}
	public GameObject mainMenu;
	public GameObject chapters;
	public void LoadMenu(string menu)
	{
		mainMenu.SetActive(menu == "main");
		chapters.SetActive(menu == "chapters");
	}
    public void QuitGame()
	{
		Application.Quit();
		Debug.Log("The game is dead");
	}
}
