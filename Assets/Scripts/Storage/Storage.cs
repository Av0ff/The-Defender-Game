using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    [SerializeField]
    private List<AssetItem> _items;

    [SerializeField]
    private StorageCell _storageCellTemplate;

    [SerializeField]
    private Transform _container;

    private void OnEnable()
    {
        Render(_items);
    }

    public void Render(List<AssetItem> items)
    {
        foreach (Transform child in _container)
            Destroy(child.gameObject);

        items.ForEach (item => 
        {
            var cell = Instantiate(_storageCellTemplate, _container);
            cell.Render(item);
        }
        );

    }
}
