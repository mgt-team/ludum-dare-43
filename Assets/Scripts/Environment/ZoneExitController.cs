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

    private GameObject _player;
    public bool _playerIsOut;

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
                _player.transform.position = Vector2.Lerp(_player.transform.position, _center.position, Time.deltaTime * distance);
                _playerIsOut = false;
            }
        }

        Debug.DrawLine(_center.position, new Vector2(_center.position.x, _center.position.y + _zoneRadius), Color.red);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == TagManager.GetTagNameByEnum(TagEnum.Player))
            _playerIsOut = true;
    }

}
