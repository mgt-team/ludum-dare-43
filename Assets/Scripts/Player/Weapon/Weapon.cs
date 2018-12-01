using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

	[SerializeField] private TagEnum _weaponTarget;
	
	private Animator _animator;

	private void Awake()
	{
		_animator = GetComponent<Animator>();
	}

	public void Attack()
	{
		_animator.SetTrigger(WeaponAnimationConsts.Attack);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (TagManager.CompareGameObjectTag(other.gameObject, _weaponTarget))
		{
			Debug.Log("Weapon beats" + other.gameObject.name);	
		}
	}
}
