using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAngleGetter : AngleGetter
{
	public GameObject Player { get; set; }

	public override float GetCurrentAngle(Transform centerPoint)
	{
		return MathUtils.GetPointOnTargetLookAngle(centerPoint.position, Player.transform.position);
	}
}
