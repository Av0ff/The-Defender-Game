using UnityEngine;

public class ShotgunBullet : Bullet
{
    public override int Damage => 10;

    public override float BulletSpeed => 500f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(Random.Range(-0.2f, 0.2f), 1) * BulletSpeed);
    }

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<ShotgunBullet>() == null)
        Destroy(gameObject);
    }
}
