using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField]
    private ShotgunBullet _sBullet;

    public override int ID => 1;
    public override int AmmunitionVolume => 6;

    public override int CurrentAmmunition { get; set; } = 6;

    private int _numGunShot = 3;

    public override float ReloadRate => 10;

    public override void Reload()
    {
        CurrentAmmunition = AmmunitionVolume;
    }

    public override void Fire()
    {
        for (int i = 0; i < _numGunShot; i++)
        {
            Instantiate(_sBullet, transform.position, transform.rotation);
        }
        CurrentAmmunition--;
        Debug.Log(CurrentAmmunition);
    }
}
