using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlace : MonoBehaviour
{

	private Animator _animator;
	
	// Use this for initialization
	void Awake ()
	{
		_animator = GetComponent<Animator>();
	}

	public void Fire()
	{
		_animator.SetTrigger(AnimationConsts.Fire);
	}
}
