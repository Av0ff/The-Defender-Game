using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player player;

    private int _health = 100;

    public static float Speed { get; } = 5;

    [SerializeField]
    private List<Weapon> _weapons;

    private Weapon _currentWeapon;

    [SerializeField]
    private int _ID = -1;

    private void Start()
    {
        player = this;

        foreach(Weapon current in _weapons)
        {
            current.gameObject.SetActive(false);
        }
    }

    public void Damage(Bullet bullet)
    {
        _health -= bullet.Damage;
    }

    public void Shoot(Weapon weapon)
    {
        if(weapon.CurrentAmmunition > 0 && weapon.isActiveAndEnabled)
        {
            weapon.Fire();
        }
    }

    private void Update()
    {
        if (SelectWeapon())
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot(_currentWeapon);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                _currentWeapon.Reload();
            }
        }

    }

    public void SelectWeaponId(int selectedWeapon)
    {
        _ID = selectedWeapon;
    }

    private bool SelectWeapon()
    {
        foreach(Weapon weapon in _weapons)
        {
            if (_ID == weapon.ID)
            {
                if (_currentWeapon != null)
                    Storage.storageCells[_currentWeapon.ID].AdItem();
                _currentWeapon?.gameObject.SetActive(false);
                _currentWeapon = weapon;
                _currentWeapon.gameObject.SetActive(true);
                Storage.storageCells[_ID].RemItem();
                return true;
            }
            else
            {
                weapon.gameObject.SetActive(false);
                if (_ID != -1)
                    Storage.storageCells[_ID].AdItem();
            }
        }
        return false;
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
