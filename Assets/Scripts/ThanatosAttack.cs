using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThanatosAttack : MonoBehaviour
{
	public Thanatos boss;
	public Rigidbody2D rbody;
	public float speed;
	public float lifetime;

	float timer;

	void Update() {
		timer += Time.deltaTime;

		if( timer > lifetime ) {
			boss.DestroyAttack( this );
			Destroy( this.gameObject );
		}
	}

	void FixedUpdate() {
		rbody.velocity = new Vector2( -speed, 0f );
	}

	void OnTriggerEnter2D( Collider2D col ) {
		DeimosController deimos = col.gameObject.GetComponent<DeimosController>();
		if( deimos != null ) {
			deimos.TakeDamageFrom( boss.dmg );
		}
		boss.DestroyAttack( this );
		Destroy( this.gameObject );
	}
}
