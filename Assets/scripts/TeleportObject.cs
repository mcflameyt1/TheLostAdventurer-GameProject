using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportObject : MonoBehaviour
{
    public string TargetScene;
    public Vector3 TargetPosition;
    public TeleportPosition CrossSceneTeleportPosition;

	private void OnTriggerEnter(Collider other)
	{
        FirstPersonController fpsController = other.GetComponent<FirstPersonController>();

        if (fpsController != null)
        {
            CrossSceneTeleportPosition.PlayerPosition = TargetPosition;
            CrossSceneTeleportPosition.PlayerRotation = fpsController.transform.rotation;
            CrossSceneTeleportPosition.ShouldTeleport = true;
            SceneManager.LoadScene(TargetScene);
        }
    }
}
