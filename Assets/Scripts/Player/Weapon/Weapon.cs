using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

	[SerializeField] private TagEnum _weaponTarget;
	[SerializeField] private WeaponConfig _weaponConfig;
	
	private Animator _animator;
	private float _currentAttackAnimationTime = 0;
	private bool _attackCompleted = false;
	
	public bool InAttack { get; private set; }

	private void Awake()
	{
		_animator = GetComponent<Animator>();
	}

	private void Update()
	{
		if (_currentAttackAnimationTime <= 0)
		{
			InAttack = false;
			_attackCompleted = false;
		}
		else
		{
			_currentAttackAnimationTime -= Time.deltaTime;		
		}
	}

	public void Attack()
	{
		if (InAttack) return;
		_animator.SetTrigger(AnimationConsts.Attack);
		InAttack = true;
		_currentAttackAnimationTime = _weaponConfig.WeaponAttackAnimationTime;
		_attackCompleted = false;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		CheckAttackTarget(other.gameObject);
	}

	private void OnTriggerStay2D(Collider2D other)
    {
	    CheckAttackTarget(other.gameObject);
    }

	private void CheckAttackTarget(GameObject target)
	{
		if (InAttack && !_attackCompleted && TagManager.CompareGameObjectTag(target, _weaponTarget))
		{
			GiveDamage(target);
			_attackCompleted = true;
		}
	}

	private void GiveDamage(GameObject target)
	{
		Debug.Log("Weapon beats " + target.name);
		var damageReceiver = target.GetComponent<DamageReceiver>();
		damageReceiver.ReceiveDamage(new DamageInfo(_weaponConfig.WeaponDamage, transform.position));
	}
}
