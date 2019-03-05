using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeMonster : MonoBehaviour
{
	public float hp;
	public float dmg;
	public float push;
	public DeimosController deimos;
	public float distanceToAttack;
	public Animator animator;
	public float speed;
	public 

	void OnCollisionEnter2D( Collision2D col ) {
		DeimosController deimos = col.gameObject.GetComponent<DeimosController>();
		if( deimos ) {
			deimos.TakeDamageFrom( this.transform, dmg, push );
		}
	}

	public void TakeDamage( float damageToTake ) {
		hp -= damageToTake;

		if( hp <= 0f ) {
			Destroy( this.gameObject );
		}
	}
	public void Update(){

		if(this.transform.position.x - deimos.transform.position.x <= distanceToAttack){
			animator.SetBool("AttackMonster", true);
			Vector3 newPos = this.transform.position;
			newPos.x -=Time.deltaTime*speed;
			this.transform.position = newPos;		//transform.position.x += Time.deltaTime*speed;
		}
		else{
			animator.SetBool("AttackMonster", false);
		}
	}
}
