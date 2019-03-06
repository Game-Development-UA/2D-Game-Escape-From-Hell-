using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMonsters : MonoBehaviour
{

	float hp;
	public HealthMonsters(float health){
		hp  = health;
	}
	public void TakeDamage( float damageToTake ) 
	{
		hp -= damageToTake;

		if( hp <= 0f ) {
			Destroy( this.gameObject );
		}
	}

}
