using UnityEngine;

public class KeyAttackController : AttackController {
    
    public override bool IsAttack()
    {
        return Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0);
    }
    
}
