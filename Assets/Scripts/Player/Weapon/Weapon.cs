using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

	[SerializeField] private TagEnum _weaponTarget;
	[SerializeField] private WeaponConfig _weaponConfig;
	
	private Animator _animator;
	private float _currentAttackAnimationTime = 0;
	
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
		}
		else
		{
			_currentAttackAnimationTime -= Time.deltaTime;
		}
	}

	public void Attack()
	{
		_animator.SetTrigger(WeaponAnimationConsts.Attack);
		InAttack = true;
		_currentAttackAnimationTime = _weaponConfig.WeaponAttackAnimationTime;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (InAttack && TagManager.CompareGameObjectTag(other.gameObject, _weaponTarget))
		{
			Debug.Log("Weapon beats " + other.gameObject.name);
			var damageReceiver = other.gameObject.GetComponent<DamageReceiver>();
			damageReceiver.ReceiveDamage(new DamageInfo(_weaponConfig.WeaponDamage, transform.position));
		}
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if (InAttack && TagManager.CompareGameObjectTag(other.gameObject, _weaponTarget))
        {
            Debug.Log("Weapon beats " + other.gameObject.name);
            var damageReceiver = other.gameObject.GetComponent<DamageReceiver>();
            damageReceiver.ReceiveDamage(new DamageInfo(_weaponConfig.WeaponDamage, transform.position));
        }
    }
}
