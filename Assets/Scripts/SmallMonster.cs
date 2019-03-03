using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallMonster : MonoBehaviour
{
	public float hp;
	public float dmg;
	public float push;

	void OnCollisionEnter2D( Collision2D col ) {
		print( "Monster hit " + col.gameObject );
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
}
