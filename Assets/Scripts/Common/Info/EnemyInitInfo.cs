using UnityEngine;

public class EnemyInitInfo
{
    public Transform Target { get; private set; }

    public EnemyInitInfo(Transform target)
    {
        Target = target;
    }
}  
