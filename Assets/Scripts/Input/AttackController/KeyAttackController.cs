using UnityEngine;

public class KeyAttackController : AttackController {
    
    public override bool IsAttack()
    {
        return Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0);
    }

    public override bool IsSprint()
    {
        return Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftShift);
    }

}
