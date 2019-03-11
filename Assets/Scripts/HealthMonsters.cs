using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthMonsters : MonoBehaviour
{

	public float hp;
	public Thanatos thanatos;
	public DieThanatos dyingPrefab;

	public void TakeDamage( float damageToTake ) 
	{
		hp -= damageToTake;

		if( hp <= 0f ) {
			
			if(thanatos!=null){
				DieThanatos dyingThanatos = Instantiate<DieThanatos>(dyingPrefab);
				DontDestroyOnLoad( dyingThanatos.gameObject);
				SceneManager.LoadScene(2);
			}
			else{
				Destroy( this.gameObject );
			}
		}
	}

}
