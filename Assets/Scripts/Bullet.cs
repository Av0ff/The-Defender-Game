using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    public abstract int Damage { get; }

    public abstract float BulletSpeed { get; }

    public abstract void OnCollisionEnter2D(Collision2D collision);
}
