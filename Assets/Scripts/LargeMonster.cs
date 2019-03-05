using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeMonster : MonoBehaviour
{
	public float hp;
	public float dmg;
	public float push;
	bool attack = false;

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
		
	}
}
