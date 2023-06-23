using StarterAssets;
using UnityEngine;

public class TeleportPlayerHandler : MonoBehaviour
{
    public TeleportPosition CrossSceneTeleportPosition;
    public ThirdPersonController PlayerController;

    private void Awake()
    {
        if (CrossSceneTeleportPosition.ShouldTeleport)
        {
            PlayerController.transform.SetLocalPositionAndRotation(CrossSceneTeleportPosition.PlayerPosition, CrossSceneTeleportPosition.PlayerRotation);
            CrossSceneTeleportPosition.ShouldTeleport = false;
        }
    }
}
