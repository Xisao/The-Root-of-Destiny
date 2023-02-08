using UnityEngine;
using UnityEngine.UI;

public class PlayerRespawnButton : MonoBehaviour
{
    public int maxRespawns = 3;
    private int remainingRespawns;
    public Transform checkpoint;
    public Transform respawnPoint;
    public Text respawnText;

    private void Start()
    {
        remainingRespawns = maxRespawns;
        UpdateRespawnText();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (remainingRespawns > 0)
            {
                if (checkpoint != null)
                {
                    transform.position = checkpoint.position;
                }
                else
                {
                    transform.position = respawnPoint.position;
                }
                remainingRespawns--;
                UpdateRespawnText();
            }
        }
    }

    private void UpdateRespawnText()
    {
        respawnText.text = "Respawns remaining: " + remainingRespawns;
    }
}
