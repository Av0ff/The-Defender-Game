using UnityEngine;

[CreateAssetMenu(menuName = "AssetItem", order = 0)]
public class AssetItem : ScriptableObject, IItem
{
    public int ID => _ID;
    public Sprite UIIcon => _uiIcon;

    [SerializeField]
    private int _ID;

    [SerializeField]
    private Sprite _uiIcon;
}
