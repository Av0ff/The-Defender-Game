using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _characterSprite;

    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private PhysicsMovement _movement;

  
    void FixedUpdate()
    {
        MoveAnimation();
        float horizontal = Input.GetAxis("Horizontal");

        _movement.Move(new Vector2 (horizontal,0));
    }

    private void MoveAnimation()
    {
        float moveInputHorizontal = Input.GetAxis("Horizontal");
        
        if (moveInputHorizontal < 0)
        {
            _characterSprite.flipX = true;
        }
        else
        {
            _characterSprite.flipX = false;
        }

        if(moveInputHorizontal == 0)
        {
            _animator.SetBool("IsRunning", false);
        }
        else
        {
            _animator.SetBool("IsRunning", true);
        }
    }
}
