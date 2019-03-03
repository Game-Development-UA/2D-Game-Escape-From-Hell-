using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallMonster : MonoBehaviour
{

	public float hp;
	public float dmg;
	void OnTriggerEnter2D( Collider2D col ) {
		Deimos deimos = col.gameObject.GetComponent<Deimos>();
		hp--;
		deimos.AddForce( new Vector2( -2f, 0f ), ForceMode2D.Impulse );
	}
}
