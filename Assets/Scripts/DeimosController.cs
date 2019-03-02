using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeimosController : MonoBehaviour {

	public Rigidbody2D player;
	public float moveSpeed;
	public Animator animator;
	public float moveThreshHold;
	public float jumpPower;
	public float health;

	void Update(){
		animator.SetBool("Moving",Mathf.Abs(player.velocity.x)  > moveThreshHold);
		if( Input.GetButtonDown("Jump") ) {
			player.AddForce( new Vector2( 0f, jumpPower ), ForceMode2D.Impulse );
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		player.velocity = new Vector2(Input.GetAxis("Horizontal")*moveSpeed, player.velocity.y);
	}
	void OnTriggerEnter2D( Collider2D col ) {
		SmallMonster monster = col.gameObject.GetComponent<SmallMonster>();
		if( monster != null ) {
			health -= monster.dmg;
			Destroy( monster.gameObject );
		}
	}
}
