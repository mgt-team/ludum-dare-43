using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultistController : EnemyBehaviorController {

    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _fightDistance;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private DamageConfig _damageConfig;

	[SerializeField] private Weapon _weapon;
	
	// Update is called once per frame
	void Update () {
        if (_target != null)
        {
            float distance = Vector2.Distance(transform.position, _target.position);
            if (distance > _fightDistance)
                transform.position = Vector2.Lerp(transform.position, _target.position, Time.deltaTime * _speed);
            else if (distance <= _fightDistance)
                Attack();
        }
	}

	public override void SetTarget(Transform targetTransform)
	{
		_target = targetTransform;
	}

    private void Attack()
    {
        _weapon.Attack();
    }
}
