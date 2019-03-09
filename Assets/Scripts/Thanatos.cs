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
	public List<Transform> attackSpawnLoc = new List<Transform>();
	public int spawnLoc;
	public int maxAttacks;
	public DeimosController deimos;
	public ThanatosAttack attackPrefab;

	void OnCollisionEnter2D( Collision2D col ) {
		DeimosController deimos = col.gameObject.GetComponent<DeimosController>();
		if( deimos ) {
			deimos.TakeDamageFrom( this.transform, dmg, push );
		}
	}
	float timer = 0;
	public void Update(){	
		
		if(this.transform.position.x - deimos.transform.position.x <= distanceToAttack){
			timer += Time.deltaTime;
			if( attacks.Count < maxAttacks) {
				ThanatosAttack newAttack = Instantiate<ThanatosAttack>(attackPrefab);
				newAttack.transform.position = attackSpawnLoc[spawnLoc].position;
				newAttack.boss = this;
				attacks.Add(newAttack);
			}
			else{
				spawnLoc = Random.Range(1,5);
			}
		}
		else{
			timer = 0;
		}
	}
	public void DestroyAttack( ThanatosAttack attackDestroyed ) {
		attacks.Remove( attackDestroyed );
	}
	
}
