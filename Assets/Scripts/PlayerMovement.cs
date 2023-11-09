using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	/// <summary>
	/// The Rigidbody2D attached to the player.
	/// </summary>
	public Rigidbody2D rigid;
	public GameObject weapon;

	[Header("Physics")]
	public float speed = 1f;
	public float jumpHeight = 1.5f;
	public float raycastOffset = 0.51f;
	public float rayDistance = 0.05f;

	private bool swing = false;

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
			StartCoroutine(SwordAnimation());
		}
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
		weapon.SetActive(true);
		swing = true;

		yield return new WaitForSeconds(0.5f);

		weapon.SetActive(false);
		swing = false;
	}
}