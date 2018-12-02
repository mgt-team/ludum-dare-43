using UnityEngine;

public class EnemyInitInfo
{
    public Transform Target { get; private set; }
    
    public GameObject Player { get; private set; }

    public EnemyInitInfo(Transform target, GameObject player)
    {
        Target = target;
        Player = player;
    }
}  
