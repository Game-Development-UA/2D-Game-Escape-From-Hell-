using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeimosMove : MonoBehaviour {

	public Rigidbody2D player;
	public float moveSpeed;

	
	// Update is called once per frame
	void Update () {
		player.velocity = new Vector2(Input.GetAxis("Horizontal")*moveSpeed, player.velocity.y);
	}
}
