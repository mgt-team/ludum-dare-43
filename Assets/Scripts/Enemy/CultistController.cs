using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultistController : EnemyBehaviorController {

    [SerializeField]
    private Sprite _afterSacrifice;

    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _fightDistance;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private DamageConfig _damageConfig;

    [SerializeField]
    private GameObject _dog;

    [SerializeField] private Weapon _weapon;

    // Update is called once per frame
	void Update () {
        if (_target != null)
        {
            float distance = Vector2.Distance(transform.position, _target.position);
            if (distance > _fightDistance)
                transform.position = Vector2.Lerp(transform.position, _target.position, Time.deltaTime * _speed);
            else if (distance <= _fightDistance)
                DoAction();
        }
	}

	public override void SetTarget(Transform targetTransform)
	{
		_target = targetTransform;
	}

    private void DoAction()
    {
        if(GetComponent<Enemy>().GetTypeEnum() == EnemyTypeEnum.CultistWithDog)
        {
            MakeSacrifice();
        }
        else
        {
            Attack();
        }
    }

    private void Attack()
    {
	    if (_weapon != null && _weapon.enabled)
	    {
		    _weapon.Attack();
	    }
    }

    private void MakeSacrifice()
    {
        var dog = Instantiate(_dog, _target.position, Quaternion.identity).GetComponent<Dog>();
        _target = null;
        GetComponent<Animator>().SetTrigger("LostDog");
        var enemy = GetComponent<Enemy>();
        enemy.SetType(EnemyTypeEnum.Cultist);
        enemy.PiktogramController.DoSacrifice(dog);
        _weapon.gameObject.SetActive(true);
    }
}
