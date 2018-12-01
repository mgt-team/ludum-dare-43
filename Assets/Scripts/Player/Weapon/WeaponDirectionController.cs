using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDirectionController : MonoBehaviour {

	[SerializeField]
	private Transform _centerPoint;
	
	private Vector3 _direction;
    
	private void Update()
	{
		var mouseAngle = MouseUtils.GetMouseAndTargetAngle(_centerPoint.position);
		LookAtCursor(mouseAngle);
	}

	private void LookAtCursor(float mouseAngle)
	{
		transform.rotation = Quaternion.AngleAxis(mouseAngle, Vector3.forward);
	}
}
