using UnityEngine;

public class Player : MonoBehaviour
{
    private int _health = 100;

    public static float Speed { get; } = 5;

    [SerializeField]
    private Pistol _pistol;

    [SerializeField]
    private Shotgun _shotgun;

    public void Damage(Bullet bullet)
    {
        _health -= bullet.Damage;
    }

    public void Shoot(Weapon weapon)
    {
        if(weapon.CurrentAmmunition > 0)
        {
            weapon.Fire();
        }
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot(_shotgun);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _shotgun.Reload();
        }
    }

    /*1 класс: оружие
     * поле объема магазина
     * поле скорости перезарядки
     * метод перезарядки
     * метод стрельбы
     * 
     * 2 класс: снаряд
     * поле дамага
     * поле скорости
     * метод oncollisionenter
     * 
     * связь классов:
     * игрок вызывает метод shoot с параметром оружия -> оружие вызывает метод shoot с параметром снаряда
     * damage вызывается у снаряда, если он достиг цель -> в параметр damage нужно поместить снаряд
     */
}
