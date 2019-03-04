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
	public float damage;
	public float stunnedVelocityThreshold;

	public int maxAttacks;

	public Transform attackSpawnLoc;

	public DeimosAttack attackPrefab;

	public List<DeimosAttack> attacks = new List<DeimosAttack>();

	bool stunned;	

	void Update(){
		if( stunned ) {
			if( player.velocity.sqrMagnitude < stunnedVelocityThreshold ) stunned = false;
		}

		animator.SetBool("Moving",Mathf.Abs(player.velocity.x)  > moveThreshHold);
		if( Input.GetButtonDown("Jump") ) {
			player.AddForce( new Vector2( 0f, jumpPower ), ForceMode2D.Impulse );
		}
		if (Input.GetMouseButtonDown(0)){
			if( attacks.Count < maxAttacks ) {
				DeimosAttack newAttack = Instantiate<DeimosAttack>( attackPrefab );
				newAttack.transform.position = attackSpawnLoc.position;
				newAttack.deimos = this;
				attacks.Add(newAttack);
			}
        	animator.SetBool("Attack",true);
		}
        else
        	animator.SetBool("Attack",false);
	}
	// Update is called once per frame
	void FixedUpdate () {
		if( stunned ) return;

		player.velocity = new Vector2(Input.GetAxis("Horizontal")*moveSpeed, player.velocity.y);
	}

	void OnCollisionEnter2D( Collision2D col ) {
		SmallMonster monster = col.gameObject.GetComponent<SmallMonster>();
		if( monster != null ) {
			monster.TakeDamage( this.damage );
		}
	}

	public void TakeDamageFrom( Transform enemy, float damageToTake, float forceToPush ) {
		health -= damageToTake;

		Vector3 intervalFromEnemy = this.transform.position - enemy.position;
		intervalFromEnemy.y = 0f; // flatten the force so that Deimos is only pushed left or right, never up or down
		intervalFromEnemy = Vector3.Normalize( intervalFromEnemy );

		player.AddForce( intervalFromEnemy * forceToPush, ForceMode2D.Impulse );

		if( forceToPush > 0f ) {
			stunned = true;
		}
	}
	public void DestroyAttack( DeimosAttack attackDestroyed ) {
		attacks.Remove( attackDestroyed );
	}
}
