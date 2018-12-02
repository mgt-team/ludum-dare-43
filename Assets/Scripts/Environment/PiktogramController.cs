using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiktogramController : MonoBehaviour
{

	private Animator _animator;
	
	// Use this for initialization
	void Awake ()
	{
		_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoSacrifice()
	{
		_animator.SetTrigger(WeaponAnimationConsts.PiktogramLight);
	}
}
