using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNewGame : MonoBehaviour {

	public Animator animator;

	public void PlayGameClicked( ){
		animator.SetBool("Exit",true);
	}
	public void FinishedTransition(){
		SceneManager.LoadScene(1);
	}
}
