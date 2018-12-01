using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonDamageEffect : DamageEffect
{
    [SerializeField]
    private float _damagePower;

    private Animator _animator;

    public override void OnDamageReceived(DamageInfo damageInfo)
    {
        DamageForce(damageInfo); 
    }

    private void DamageForce(DamageInfo damageInfo)
    {
        Blinking();
        transform.position = Vector2.MoveTowards(transform.position, -damageInfo.AssaulterPosition * damageInfo.DamageCount * _damagePower, Time.deltaTime * damageInfo.DamageCount * _damagePower);
    }

    private void Blinking()
    {
        _animator.SetTrigger(WeaponAnimationConsts.Damage);
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
}
