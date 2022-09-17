using UnityEngine;

public class Pistol : Weapon
{
    [SerializeField]
    private PistolBullet _pBullet;

    public override int AmmunitionVolume => 20;

    public override int CurrentAmmunition { get; set; } = 20;

    public override float ReloadRate => 5f;

    public override void Reload()
    {
        CurrentAmmunition = AmmunitionVolume;
    }

    public override void Fire()
    {
        Instantiate(_pBullet, transform.position, transform.rotation);
        CurrentAmmunition--;
        Debug.Log(CurrentAmmunition);
    }

}
