using UnityEngine;

public class PistolBullet : Bullet
{
    public override int Damage => 10;

    public override float BulletSpeed => 200f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * BulletSpeed);
    }

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
