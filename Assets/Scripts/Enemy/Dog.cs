using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{

	[SerializeField] private DogConfig _dogConfig;
	
	private Dieble _dieble;
	private float _timeToDie = 0;
	
	// Use this for initialization
	void Awake ()
	{
		_dieble = GetComponent<Dieble>();
	}
	
	// Update is called once per frame
	void Update () {
		if (_timeToDie > 0)
		{
			_timeToDie -= Time.deltaTime;
		}
		else
		{
			_dieble.Die();
		}
	}

	public void BeSacrificed()
	{
		_timeToDie = _dogConfig.TimeToDie;
	}
}
