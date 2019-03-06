using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeMonster : MonoBehaviour
{

	public float dmg;
	public float push;
	public DeimosController deimos;
	public float distanceToAttack;
	public Animator animator;
	public float speed;
	public HealthMonsters health;

	void OnCollisionEnter2D( Collision2D col ) {
		DeimosController deimos = col.gameObject.GetComponent<DeimosController>();
		if( deimos ) {
			deimos.TakeDamageFrom( this.transform, dmg, push );
		}
	}
	public void Update(){
		if(Mathf.Abs(this.transform.position.x - deimos.transform.position.x)<= distanceToAttack){
			animator.SetBool("AttackMonster", true);
			Vector3 newPos = this.transform.position;
			newPos.x -=Time.deltaTime*speed;
			this.transform.position = newPos;
		}
		else{
			animator.SetBool("AttackMonster", false);
		}
	}
}
