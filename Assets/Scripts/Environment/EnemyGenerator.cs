using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    [SerializeField]
    private List<Enemy> _enemies;

    [SerializeField]
    private float _distanceOfGenerating;

    [SerializeField]
    private EnemyManager _enemyManager;

    private float _zoneRadius;

	// Use this for initialization
	void Awake () {
        _zoneRadius = GetComponent<ZoneExitController>().GetZoneRadius();
        _enemyManager = GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.G))
        {
            GenerateRandomEnemy();
        }
	}

    private void GenerateRandomEnemy()
    {
        var enemy = Instantiate(_enemies[Random.Range(0, _enemies.Count)], GetRandomPosition(), Quaternion.identity);
        _enemyManager.InitEnemy(enemy);
    }

    private Vector2 GetRandomPosition()
    {
        float randomAngle = Random.Range(0, 360);
        return new Vector2(Mathf.Sin(randomAngle), Mathf.Cos(randomAngle)) * (_zoneRadius + _distanceOfGenerating);
    }

}
