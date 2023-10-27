using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartHidden : MonoBehaviour
{
	public GameObject gameObject;
	void Start()
	{
		gameObject.SetActive(false);
	}
}