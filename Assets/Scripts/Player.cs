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
