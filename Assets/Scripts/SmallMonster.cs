using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallMonster : MonoBehaviour
{
	public float dmg;
	public float push;
	public HealthMonsters health;

	void OnCollisionEnter2D( Collision2D col ) {
		DeimosController deimos = col.gameObject.GetComponent<DeimosController>();

		if( deimos ) {
			deimos.TakeDamageFrom( this.transform, dmg, push );
		}
	}
}
