using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StorageCell : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Image _iconField;

    [SerializeField]
    private int _idWeapon;

    private void OnEnable()
    {
        //Storage.OnItemRemove += RemItem;
        //Storage.OnItemAdd += AdItem;
        //GetComponent<Image>().enabled = false;
    }

    public void Render(IItem item)
    {
        _iconField.sprite = item.UIIcon;
        _idWeapon = item.ID;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Player.player.SelectWeaponId(_idWeapon);
    }

    public void RemItem()
    {
        GetComponent<Image>().enabled = false;
    }

    public void AdItem()
    {
        GetComponent<Image>().enabled = true;
    }

    private void OnDisable()
    {
    //    Storage.OnItemRemove -= RemItem;
    //    Storage.OnItemAdd -= AdItem;
    }
}
