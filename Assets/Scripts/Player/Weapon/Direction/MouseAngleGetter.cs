using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAngleGetter : AngleGetter {

	public override float GetCurrentAngle(Transform centerPoint)
	{
		return MouseUtils.GetMouseAndTargetAngle(centerPoint.position);
	}
}
