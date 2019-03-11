using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieThanatos : MonoBehaviour
{
   public float lifetime;

	void Start() 
	{ 
		Destroy( this.gameObject, lifetime ); 
	}
}
