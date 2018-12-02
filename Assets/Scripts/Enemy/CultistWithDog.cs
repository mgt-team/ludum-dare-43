using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultistWithDog : EnemyBehaviorController
{

    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _fightDistance;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private GameObject _dog;

    private GameObject _player;
    
    public override void SetTarget(Transform targetTransform)
    {
        _target = targetTransform;
    }

    public override void SetPlayer(GameObject player)
    {
        _player = player;
    }

    void Update()
    {
        if (_target != null)
        {
            float distance = Vector2.Distance(transform.position, _target.position);
            if (distance > _fightDistance)
                transform.position = Vector2.Lerp(transform.position, _target.position, Time.deltaTime * _speed);
            else if (distance <= _fightDistance)
                MakeSacrifice();
        }
    }

    private void MakeSacrifice()
    {
        Instantiate(_dog, _target.position, Quaternion.identity);
    }
    
    
}
