using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    private Transform _target;

    [SerializeField]
    private float _radiusDetection = 6f;

    [SerializeField]
    private float _radiusAttack = 4f;

    [SerializeField]
    private LayerMask _player;

    private void Update()
    {
        var checkCircleAttack = Physics2D.OverlapCircle(GetComponent<Rigidbody2D>().position, _radiusAttack, _player);
        var checkCircleDetection = Physics2D.OverlapCircle(GetComponent<Rigidbody2D>().position, _radiusDetection, _player);

        if (checkCircleAttack)
        {
            Attack();
        }
        if (checkCircleDetection)
        {
            Chase();
        }
        else
        {
            Patrol();
        }
    }

    private void Patrol()
    {

    }

    private void Chase()
    {

    }

    private void Attack()
    {

    }
}
