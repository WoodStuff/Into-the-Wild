using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPBar : MonoBehaviour
{
	[SerializeField] TMP_Text text;
	[SerializeField] Player player;

	void Start()
	{
		Debug.Log("start");
		UpdateCounter();
	}

	public void UpdateCounter()
	{
		Debug.Log("update");
		text.text = "HP: " + player.stats.HP.ToString() + "/" + player.stats.HPmax.ToString();
	}
}
