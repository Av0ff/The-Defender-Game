using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StorageCell : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private Image _iconField;

    [SerializeField]
    private int _idWeapon;

    public void Render(IItem item)
    {
        _iconField.sprite = item.UIIcon;
        _idWeapon = item.ID;
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("AAAa");
        Player.player.SelectWeaponId(_idWeapon);
        gameObject.SetActive(false);
    }
}
