using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thanatos : MonoBehaviour
{
	public float dmg;
	public float push;
	public HealthMonsters health;
	public float distanceToAttack;
	public float intervalToChangePos;
	public float intervalToAttack;
	public List<ThanatosAttack> attacks = new List<ThanatosAttack>();
	public Transform attackSpawnLoc;
	public int maxAttacks;
	public DeimosController deimos;

	void OnCollisionEnter2D( Collision2D col ) {
		DeimosController deimos = col.gameObject.GetComponent<DeimosController>();
		if( deimos ) {
			deimos.TakeDamageFrom( this.transform, dmg, push );
		}
	}
	public void Update(){
		if(this.transform.position.x - deimos.transform.position.x <= distanceToAttack){
			if( attacks.Count < maxAttacks ) {
				ThanatosAttack newAttack = Instantiate<ThanatosAttack>(ThanatosAttack);
				newAttack.transform.position = attackSpawnLoc.position;
				newAttack.deimos = this;
				attacks.Add(newAttack);
			}
		}
	}

}
