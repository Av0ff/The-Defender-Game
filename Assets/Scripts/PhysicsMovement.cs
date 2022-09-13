using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private Rigidbody2D _rigidbodyCharacter;

    [SerializeField]
    private SurfaceSlider _surfaceSlider;

    public void Move(Vector2 direction)
    {
        Vector2 directionAlongSurface = _surfaceSlider.Project(direction.normalized);
        Vector2 offset = directionAlongSurface * (_speed * Time.deltaTime);

        _rigidbodyCharacter.MovePosition(_rigidbodyCharacter.position + offset);
    }
}
