using UnityEngine;

public class Player : MonoBehaviour
{
    private int _health = 100;

    public static float Speed { get; } = 5;

    [SerializeField]
    private Pistol _pistol;

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
            Shoot(_pistol);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _pistol.Reload();
        }
    }

    /*1 �����: ������
     * ���� ������ ��������
     * ���� �������� �����������
     * ����� �����������
     * ����� ��������
     * 
     * 2 �����: ������
     * ���� ������
     * ���� ��������
     * ����� oncollisionenter
     * 
     * ����� �������:
     * ����� �������� ����� shoot � ���������� ������ -> ������ �������� ����� shoot � ���������� �������
     * damage ���������� � �������, ���� �� ������ ���� -> � �������� damage ����� ��������� ������
     */
}
