using UnityEngine;

public class OpsStandart : Enemy
{
    public override int Hp { get; protected set; } = 100;
    public override float Speed { get; protected set; } = 4;

    [SerializeField]
    private Weapon _currentWeapon;

    private void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            Shoot(_currentWeapon);
        }
    }

}
