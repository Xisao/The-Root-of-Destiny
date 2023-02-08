using UnityEngine;

public class CheckpointTeleport : MonoBehaviour
{
    private GameObject player;
    private GameObject[] checkpoints;

    private void Start()
    {
        player = GameObject.FindWithTag("player");
        checkpoints = GameObject.FindGameObjectsWithTag("checkpoint");
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "checkpoint" && player != null)
        {
            TeleportPlayerToNearestCheckpoint();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && player != null)
        {
            TeleportPlayerToNearestCheckpoint();
        }
    }

    private void TeleportPlayerToNearestCheckpoint()
    {
        float minDistance = float.MaxValue;
        GameObject nearestCheckpoint = null;

        foreach (GameObject checkpoint in checkpoints)
        {
            float distance = Vector2.Distance(player.transform.position, checkpoint.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestCheckpoint = checkpoint;
            }
        }

        if (nearestCheckpoint != null)
        {
            player.transform.position = nearestCheckpoint.transform.position;
        }
    }
}
