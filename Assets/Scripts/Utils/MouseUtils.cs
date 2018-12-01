using UnityEngine;

public static class MouseUtils {
    
    public static float GetMouseAndTargetAngle(Vector3 targetPosition)
    {
        return MathUtils.GetPointOnTargetLookAngle(targetPosition, GetMousePosition());
    }

    public static Vector3 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.transform.position.z));
    }
}
