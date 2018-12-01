using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

	[SerializeField] private TagEnum _weaponTarget;
	[SerializeField] private WeaponConfig _weaponConfig;
	
	private Animator _animator;

	private void Awake()
	{
		_animator = GetComponent<Animator>();
	}

	public void Attack()
	{
		_animator.SetTrigger(WeaponAnimationConsts.Attack);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (TagManager.CompareGameObjectTag(other.gameObject, _weaponTarget))
		{
			Debug.Log("Weapon beats " + other.gameObject.name);
			var damageReceiver = other.gameObject.GetComponent<DamageReceiver>();
			damageReceiver.ReceiveDamage(new DamageInfo(_weaponConfig.WeaponDamage, transform.position));
		}
	}
}
