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
    
    private Liveble _liveble;

    public void Init(EnemyInitInfo enemyInitInfo)
    {
        _liveble = GetComponent<Liveble>();
        _liveble.InitHp();
        
        SetTarget(enemyInitInfo.Target);
    }
    
    public void SetTarget(Transform target)
    {
        _target = target;
        _enemyBehaviorController = GetComponent<EnemyBehaviorController>();
        if (_enemyBehaviorController != null)
            _enemyBehaviorController.SetTarget(_target);
    }

    public EnemyTypeEnum GetType()
    {
        return _type;
    }
}
