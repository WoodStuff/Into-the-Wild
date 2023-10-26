using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : Entity
{
	[SerializeField] private HPBar hpBar;
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.H)) stats.HP--;
		hpBar.UpdateCounter();
	}
}