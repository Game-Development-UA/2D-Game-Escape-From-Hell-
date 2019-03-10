using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthMonsters : MonoBehaviour
{

	public float hp;
	public Thanatos thanatos;
	
	public void TakeDamage( float damageToTake ) 
	{
		hp -= damageToTake;

		if( hp <= 0f ) {
			Destroy( this.gameObject );
			if(thanatos!=null){
				SceneManager.LoadScene(2);
			}
		}
	}

}
