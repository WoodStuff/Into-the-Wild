using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
	/// <summary>
	/// The Rigidbody2D attached to the player.
	/// </summary>
	[SerializeField] private Rigidbody2D rigid;
	[SerializeField] private GameObject weapon;
	[SerializeField] private HPBar hpBar;

	[Header("Physics")]
	public float speed = 1f;
	public float jumpHeight = 1.5f;
	public float raycastOffset = 0.51f;
	public float rayDistance = 0.05f;

	private bool swing = false;
	private Vector3 swordPos = Vector3.zero;

	void Start()
	{
		weapon.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		Vector2 move = new(Input.GetAxisRaw("Horizontal"), 0);
		rigid.position += 5 * speed * Time.deltaTime * move;

		if (Input.GetAxisRaw("Jump") > 0 && GroundCheck() && rigid.velocity.y <= 0) rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight * 5);
		Debug.DrawRay(rigid.position - new Vector2(0.5f, raycastOffset), Vector2.down * new Vector2(0, rayDistance), Color.green);
		Debug.DrawRay(rigid.position - new Vector2(-0.5f, raycastOffset), Vector2.down * new Vector2(0, rayDistance), Color.blue);

		if (!swing && Input.GetMouseButtonDown(0))
		{
			Vector3 posScreen = Input.mousePosition;
			posScreen.z = 10;
			swordPos = (Camera.main.ScreenToWorldPoint(posScreen) - gameObject.transform.position).normalized;
			Debug.Log(swordPos);

			StartCoroutine(SwordAnimation());
		}

		if (Input.GetKeyDown(KeyCode.H)) stats.HP--;
		hpBar.UpdateCounter();
	}

	private bool GroundCheck()
	{
		bool left = false;
		bool right = false;

		// left
		RaycastHit2D hit1 = Physics2D.Raycast(rigid.position - new Vector2(0.5f, raycastOffset), Vector2.down);
		if (!(hit1.collider == null || hit1.distance > rayDistance) && hit1.collider.gameObject.CompareTag("Wall")) left = true;

		// right
		RaycastHit2D hit2 = Physics2D.Raycast(rigid.position - new Vector2(-0.5f, raycastOffset), Vector2.down);
		if (!(hit2.collider == null || hit2.distance > rayDistance) && hit2.collider.gameObject.CompareTag("Wall")) right = true;
		return left || right;
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

		yield return new WaitForSeconds(0.1f);

		weapon.transform.position -= new Vector3(-swordPos.y, swordPos.x, 0);
		weapon.transform.rotation = Quaternion.Euler(0f, 0f, angleDeg - 45);

		yield return new WaitForSeconds(0.4f);

		weapon.SetActive(false);
		swing = false;
	}
}