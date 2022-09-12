using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private SpriteRenderer _characterSprite;

    private Rigidbody2D _rigidbodyCharacter;

    private Vector2 _NewPositionCharacter;

    void Start()
    {
        _rigidbodyCharacter = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move(_speed);
    }
    private void Move(float speed)
    {
        _NewPositionCharacter = new Vector2(transform.position.x + Input.GetAxisRaw("Horizontal") * speed, transform.position.y + 0);
        _rigidbodyCharacter.MovePosition(_NewPositionCharacter);
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            _characterSprite.flipX = true;
        }
        else
        {
            _characterSprite.flipX = false;
        }
    }
}
