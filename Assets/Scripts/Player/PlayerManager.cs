using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    [SerializeField]
    private Player _player;

    [SerializeField]
    private SoundManager _soundManager;
    
    private MoveController _moveController;
    private Animator _animator;
    private AttackController _attackController;
    
    private void Awake()
    {
        _moveController = GetComponent<MoveController>();
        _attackController = GetComponent<AttackController>();
    }

    // Use this for initialization
    void Start()
    {
        _player.Init();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlayerMovement();

        if (_attackController.IsAttack())
        {
            Attack();
        }

        if (_attackController.IsSprint())
        {
            _player.Sprint();
        }
            
    }

    private void UpdatePlayerMovement()
    {
        Vector2 velocity = _moveController.GetVelocity();
        _player.SetVelocity(velocity);
        /*if (velocity == Vector2.zero)
            _player.StopAnimation();
        else
            _player.StartAnimation();*/
    }

    private void Attack()
    {
        _player.Attack();
    }
}