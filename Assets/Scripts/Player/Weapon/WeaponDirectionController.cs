using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDirectionController : MonoBehaviour {

	[SerializeField]
	private Transform _centerPoint;
	
	private Vector3 _direction;
	private AngleGetter _angleGetter;

	private void Awake()
	{
		_angleGetter = GetComponent<AngleGetter>();
	}

	private void Update()
	{
		LookAtCursor(_angleGetter.GetCurrentAngle(_centerPoint));
	}

	private void LookAtCursor(float mouseAngle)
	{
		transform.rotation = Quaternion.AngleAxis(mouseAngle, Vector3.forward);
	}
}
