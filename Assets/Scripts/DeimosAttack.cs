using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeimosAttack : MonoBehaviour
{	
	public Rigidbody2D player;
	public Animator animator;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        	animator.SetBool("Attack",true);
        else
        	animator.SetBool("Attack",false);
        
    }
}
