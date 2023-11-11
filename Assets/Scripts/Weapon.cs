using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject wind;

	void Start()
	{
		gameObject.SetActive(false);
		wind.SetActive(false);
	}
}