using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private GameObject weapon;
	[SerializeField] private GameObject wind;
	[SerializeField] private float[] timings = new float[4];

	private bool swing = false;
	private Vector3 swordPos = Vector3.zero;

	void Update()
	{
		if (!swing && Input.GetMouseButtonDown(0))
		{
			Vector3 posScreen = Input.mousePosition;
			posScreen.z = 10;
			swordPos = (Camera.main.ScreenToWorldPoint(posScreen) - gameObject.transform.position).normalized;
			Debug.Log(swordPos);

			StartCoroutine(SwordAnimation());
		}
	}

	IEnumerator SwordAnimation()
	{
		float angleRad = Mathf.Atan2(swordPos.y, swordPos.x);
		float angleDeg = Mathf.Rad2Deg * angleRad - 45;

		Vector3 perpendicular = new Vector3(-swordPos.y, swordPos.x, 0) * 0.5f;

		weapon.transform.SetPositionAndRotation(
			gameObject.transform.position + swordPos + perpendicular,
			Quaternion.Euler(0f, 0f, angleDeg + 45)
		);
		weapon.SetActive(true);
		swing = true;

		yield return new WaitForSeconds(timings[0]);

		wind.transform.rotation = Quaternion.Euler(0f, 0f, angleDeg + 135);
		wind.SetActive(true);

		weapon.transform.position -= new Vector3(-swordPos.y, swordPos.x, 0);
		weapon.transform.rotation = Quaternion.Euler(0f, 0f, angleDeg - 45);

		yield return new WaitForSeconds(timings[1]);

		wind.SetActive(false);

		yield return new WaitForSeconds(timings[2]);

		weapon.SetActive(false);

		yield return new WaitForSeconds(timings[3]);

		swing = false;
	}
}