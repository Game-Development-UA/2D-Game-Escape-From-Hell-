using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthMonsters : MonoBehaviour
{

	public float hp;
	public Thanatos thanatos;
	public AudioSource dyingSound;
	
	public void TakeDamage( float damageToTake ) 
	{
		hp -= damageToTake;

		if( hp <= 0f ) {
			dyingSound.Play();
			Destroy( this.gameObject );
			if(thanatos!=null){
				SceneManager.LoadScene(2);
			}
		}
	}

}
