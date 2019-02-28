using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeimosMove : MonoBehaviour {

	public Rigidbody2D player;
	public float moveSpeed;
	public Animator animator;
	public float moveThreshHold;

	void Update(){
		animator.SetBool("Moving",Mathf.Abs(player.velocity.x)  > moveThreshHold);
	}
	// Update is called once per frame
	void FixedUpdate () {
		player.velocity = new Vector2(Input.GetAxis("Horizontal")*moveSpeed, player.velocity.y);
	}
}
