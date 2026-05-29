using UnityEngine;

public class RacketDynamicWidth : MonoBehaviour
{
    public SpriteRenderer left;
    public SpriteRenderer right;
    public SpriteRenderer centre;
    public BoxCollider2D hitboxRect;
    public CapsuleCollider2D hitboxCapsule;

    // Update is called once per frame
    void Update()
    {
        // our bounds
        float width = centre.bounds.extents.x;
        left.transform.position = centre.transform.position - new Vector3(width + left.bounds.extents.x, 0, 0);
        right.transform.position = centre.transform.position + new Vector3(width + right.bounds.extents.x, 0, 0);

        // dimensions of collider
        Vector2 colliderSize = new(left.bounds.size.x + right.size.x + centre.size.x, centre.size.y);
        hitboxRect.size = colliderSize;
        hitboxCapsule.size = colliderSize;
    }
}
