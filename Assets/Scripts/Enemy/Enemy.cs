using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public abstract int Hp { get; protected set; }

    public abstract float Speed { get; protected set; }

    public void Damage(Bullet bullet)
    {
        Hp -= bullet.Damage;
    }

    public void Shoot(Weapon weapon)
    {
        if (weapon.CurrentAmmunition > 0 && weapon.isActiveAndEnabled)
        {
            weapon.Fire();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var bullet = collision.gameObject.GetComponent<Bullet>();
        if (bullet)
        {
            Damage(bullet);
        }
    }

}
