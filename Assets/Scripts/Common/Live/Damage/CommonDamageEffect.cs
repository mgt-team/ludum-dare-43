using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonDamageEffect : DamageEffect
{
    public override void OnDamageReceived(DamageInfo damageInfo)
    {
        DamageForce(damageInfo); 
    }

    private void DamageForce(DamageInfo damageInfo)
    {
        transform.position = Vector2.Lerp(transform.position, damageInfo.AssaulterPosition, Time.deltaTime * damageInfo.DamageCount);
    }
}
