using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public Transform player; // assign the player in the Inspector
    public float speed = 5f;

    void Update()
    {
        // calculate the direction to the player
        Vector3 direction = (player.position - transform.position).normalized;

        // move the cube towards the player
        transform.position += direction * speed * Time.deltaTime;
    }
}
