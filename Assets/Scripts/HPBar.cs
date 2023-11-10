using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPBar : MonoBehaviour
{
	[SerializeField] TMP_Text text;
	[SerializeField] Player player;

	void Start()
	{
		UpdateCounter();
	}

	public void UpdateCounter()
	{
		text.text = "HP: " + player.stats.HP.ToString() + "/" + player.stats.MaxHP.ToString();
	}
}
