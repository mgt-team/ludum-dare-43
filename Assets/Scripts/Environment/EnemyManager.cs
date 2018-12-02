using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    [SerializeField]
    private Transform _zoneCenter;

    [SerializeField]
    private Transform _player;

    [SerializeField] private PiktogramController _piktogramController;

    private Enemy _enemy;

    public Transform GetEnemyTarget(EnemyTypeEnum enemyType)
    {
        if (enemyType == EnemyTypeEnum.CultistWithDog)
        {
            return _zoneCenter;
        }
        else
        {
            return _player;
        }
    }

    public void InitEnemy(Enemy enemy)
    {
        var enemyInitInfo = new EnemyInitInfo(GetEnemyTarget(enemy.GetTypeEnum()), _player.gameObject, _piktogramController);
        enemy.Init(enemyInitInfo);
        enemy.TypeChanged += Enemy_TypeChanged;
    }

    private void Enemy_TypeChanged(Enemy enemy)
    {
        InitEnemy(enemy);
    }
}
