using System;
using UnityEngine;

public class Player : Entity
{
	/// <summary>
	/// The Rigidbody2D attached to the player.
	/// </summary>
	[SerializeField] private Rigidbody2D rigid;
	[SerializeField] private HPBar hpBar;

	[Header("Physics")]
	public float speed = 1f;
	public float jumpHeight = 1.5f;
	public float raycastOffset = 0.51f;
	public float rayDistance = 0.05f;
	
	void Update()
	{
		Vector2 move = new(Input.GetAxisRaw("Horizontal"), 0);
		rigid.position += 5 * speed * Time.deltaTime * move;

		if (Input.GetAxisRaw("Jump") > 0 && GroundCheck() && rigid.velocity.y <= 0) rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight * 5);
		Debug.DrawRay(rigid.position - new Vector2(0.5f, raycastOffset), Vector2.down * new Vector2(0, rayDistance), Color.green);
		Debug.DrawRay(rigid.position - new Vector2(-0.5f, raycastOffset), Vector2.down * new Vector2(0, rayDistance), Color.blue);

		if (Input.GetKeyDown(KeyCode.H)) stats.HP--;
		hpBar.UpdateCounter();

		gameObject.transform.position = new Vector3(
			(float)Math.Round(gameObject.transform.position.x, 2),
			(float)Math.Round(gameObject.transform.position.y, 2),
			0
		);
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
}