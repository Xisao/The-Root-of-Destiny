using UnityEngine;

public class LightAndShadow : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        spriteRenderer.maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        spriteRenderer.maskInteraction = SpriteMaskInteraction.None;
    }
}
