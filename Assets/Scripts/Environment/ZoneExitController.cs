using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneExitController : MonoBehaviour {

    [SerializeField]
    private Transform _center;

    [SerializeField]
    private float _forcePower;

    [SerializeField]
    private float _zoneRadius;

    [SerializeField]
    private float _distanceOfForce;

    private GameObject _player;
    private float timer;

    private void Awake()
    {
        _player = GameObject.Find("Player");
    }

    private void Update()
    {
        if (_player != null) {
            float distance = Vector2.Distance(_center.position, _player.transform.position);
            if (distance > _zoneRadius)
            {
                timer = _distanceOfForce;
            }
            if(timer > 0)
            {
                _player.transform.position = Vector2.LerpUnclamped(_player.transform.position, _center.position, Time.deltaTime * distance * _forcePower);
                timer -= Time.deltaTime;
            }
        }

        Debug.DrawLine(_center.position, new Vector2(_center.position.x, _center.position.y + _zoneRadius), Color.red);
    }

}
