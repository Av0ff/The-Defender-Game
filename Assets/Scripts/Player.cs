using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health { get; } = 100;

    public static float Speed { get; } = 5;

    
    public void Damage(int damage)
    {

    }

    public void Shoot()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
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
