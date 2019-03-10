﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeimosHealth : MonoBehaviour
{
	public void ReduceHp(float healthAt,float maxHp){
		if(healthAt >= 0)
			this.transform.localScale = new Vector3(healthAt/maxHp,1f,0.9599995f);
		if(healthAt <= 0){
			 SceneManager.LoadScene(2);
		}
	}
}
