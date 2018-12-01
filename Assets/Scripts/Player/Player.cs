using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour {
	
	[SerializeField]
	private Vector2 _shiftPower;

    [SerializeField]
    private float _sprintPower;

    [SerializeField]
    private float _timeSprint;

	[SerializeField] private Weapon _weapon;

	private Rigidbody2D _rigidbody;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
	private Liveble _liveble;
    private bool _isSprint;
    private float _timerForSprint;

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
		_liveble = GetComponent<Liveble>();
	}

	// Use this for initialization
	void Start () {
        _isSprint = false;
	}

	public void Init()
	{
		_liveble.InitHp();
	}

    public void StopAnimation()
    {
        _animator.SetBool("isRun", false);
    }

    public void StartAnimation()
    {
        _animator.SetBool("isRun", true);
    }

	public void Attack()
	{
		_weapon.Attack();
	}

    public void Sprint()
    {
        _isSprint = true;
        _timerForSprint = _timeSprint;
    }
	
	// Update is called once per frame
	void Update () {
        if (_timerForSprint > 0)
        {
            _timerForSprint -= Time.deltaTime;
        }
        else if (_timerForSprint <= 0)
            _isSprint = false;
	}
	
	public void SetVelocity(Vector2 direction)
	{
		//_rigidbody.MovePosition(direction * _shiftPower );
		/*_rigidbody.AddForce(direction * _shiftPower);
		return;*/
		
		if (direction.x != 0 || direction.y != 0)
			direction *= Mathf.Sqrt(2) / 2;

		var shiftPowerY = _shiftPower.y;

		if(direction.y < 0)
		{
			shiftPowerY *= 2;
		}
		else
		{
			shiftPowerY *= 1.5f;
		}
        if (_isSprint)
        {
            direction *= _sprintPower;
        }
		_rigidbody.velocity = new Vector3(direction.x * _shiftPower.x, direction.y * shiftPowerY);
	}
}
