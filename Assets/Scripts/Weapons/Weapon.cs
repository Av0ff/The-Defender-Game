using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public abstract int ID { get; }

    public abstract int AmmunitionVolume { get;}

    public abstract int CurrentAmmunition { get; set; }

    public abstract float ReloadRate { get; }

    public abstract void Reload();

    public abstract void Fire();
}
