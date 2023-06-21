using UnityEngine;

[CreateAssetMenu(menuName = "TeleportPosition Scriptable", fileName = "CrossSceneTeleportPosition")]
public class TeleportPosition : ScriptableObject
{
    public bool ShouldTeleport = false;
    public Vector3 PlayerPosition;
    public Quaternion PlayerRotation;
}
