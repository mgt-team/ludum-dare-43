using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehaviorController : MonoBehaviour
{
	public abstract void SetTarget(Transform targetTransform);
}
