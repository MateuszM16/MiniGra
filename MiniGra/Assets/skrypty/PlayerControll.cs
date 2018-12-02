using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour {
	public Rigidbody2D rb;
	public GameObject Gracz;
	public Transform groundCheck1;
	public Transform groundCheck2;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool onGround1;
	private bool onGround2;
	float i=0;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		i = Gracz.gameObject.transform.position.x / 50;

		rb.velocity = new Vector2 (3+i, rb.velocity.y);
		onGround1 = Physics2D.OverlapCircle (groundCheck1.position, groundCheckRadius, whatIsGround);
		onGround2 = Physics2D.OverlapCircle (groundCheck2.position, groundCheckRadius, whatIsGround);

		if (Input.GetMouseButtonDown (0) && (onGround1 || onGround1))
		{
			rb.velocity = new Vector2 (rb.velocity.x, 8);
		}

		if (rb.velocity.y < -20) {
			Application.LoadLevel (1);
		}
	}
}
