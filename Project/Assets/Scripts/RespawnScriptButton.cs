using UnityEngine;

public class RespawnScriptButton : MonoBehaviour
{
    public Transform respawnPoint; // The position the player will respawn at

    private void Update()
    {
        // Check if the player presses the "R" key
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Respawn the player
            RespawnPlayer();
        }
    }

    private void RespawnPlayer()
    {
        // Set the player's position to the respawn point
        transform.position = respawnPoint.position;
    }
}
