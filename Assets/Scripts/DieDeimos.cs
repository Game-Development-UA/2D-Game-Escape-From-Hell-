using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieDeimos: MonoBehaviour
{
	public float lifetime;

	void Start() 
	{ 
		Destroy( this.gameObject, lifetime ); 
	}
   
}
