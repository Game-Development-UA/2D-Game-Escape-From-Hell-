using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeimosAttack : MonoBehaviour
{	
	public Rigidbody2D rbody;
	public float speed;
	public float lifetime;

	public DeimosController deimos;

	float timer;

	void Update() {
		timer += Time.deltaTime;

		if( timer > lifetime ) {
			deimos.DestroyAttack( this );
			Destroy( this.gameObject );
		}
	}

	void FixedUpdate() {
		rbody.velocity = new Vector2( speed, 0f );
	}

	/*void OnTriggerEnter2D( Collider2D col ) {
		Destroyable destroyable = col.GetComponent<Destroyable>();

		if( destroyable ) {
			Destroy( destroyable.gameObject );
		}

		playerOwner.ProjectileDestroyed( this );
		Destroy( this.gameObject );
	}*/
}
