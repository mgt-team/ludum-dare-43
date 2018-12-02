using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableElementDie : Dieble {

    [SerializeField]
    private float _animationTimer;
    private bool _isDie;
    private float _timer;

	public override void Die()
	{
        GetComponent<Animator>().SetTrigger("Die");
        _timer = _animationTimer;
        _isDie = false;
		//gameObject.SetActive(false);
	}

    private void Update()
    {
        if(_timer > 0)
        {
            _timer -= Time.deltaTime;
            _isDie = false;
        }
        if(_timer < 0)
        {
            _isDie = true;
        }
        if (_timer < 0 && _isDie)
            Destroy(gameObject);
    }
}
