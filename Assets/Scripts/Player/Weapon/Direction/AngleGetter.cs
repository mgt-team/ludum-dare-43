using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AngleGetter : MonoBehaviour
{
    public abstract float GetCurrentAngle(Transform centerPoint);
}
