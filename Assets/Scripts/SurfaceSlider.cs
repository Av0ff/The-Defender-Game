using UnityEngine;

public class SurfaceSlider : MonoBehaviour
{
    private Vector2 _normal;

    public Vector2 Project(Vector2 direction)
    {
        return direction - Vector2.Dot(direction, _normal) * _normal;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.contacts[0].collider.CompareTag("Ground"))
        {
            _normal = collision.contacts[0].normal;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(_normal.x,_normal.y, 0) * 3);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + new Vector3(Project(-transform.right).x,Project(-transform.right).y, 0) * 3);
    }
}
