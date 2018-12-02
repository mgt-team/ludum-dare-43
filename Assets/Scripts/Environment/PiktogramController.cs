using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiktogramController : MonoBehaviour
{

	[SerializeField] private FirePlace _firePlace;
	
	private Animator _animator;
	
	// Use this for initialization
	void Awake ()
	{
		_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoSacrifice(Dog dog)
	{
		_animator.SetTrigger(AnimationConsts.PiktogramLight);
		_firePlace.Fire();
		dog.BeSacrificed();
	}
}
