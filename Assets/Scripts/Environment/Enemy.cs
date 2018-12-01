using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    private EnemyTypeEnum _type;

    [SerializeField]
    private Transform _target;

    [SerializeField]
    private EnemyBehaviorController _enemyBehaviorController;

    private void Awake()
    {
        _enemyBehaviorController = GetComponent<EnemyBehaviorController>();
        _enemyBehaviorController.SetTarget(_target);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    public EnemyTypeEnum GetType()
    {
        return _type;
    }
}
