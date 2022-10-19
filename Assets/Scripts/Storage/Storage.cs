using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Storage : MonoBehaviour
{
    [SerializeField]
    private List<AssetItem> _items;

    [SerializeField]
    private StorageCell _storageCellTemplate;

    [SerializeField]
    private Transform _container;

    public static List<StorageCell> storageCells { get; private set; } = new();

    //public static event Action OnItemRemove;

    ///public static event Action OnItemAdd;

    private void OnEnable()
    {
        Render(_items);
    }

    private void Update()
    {
        
    }

    public void Render(List<AssetItem> items)
    {
        foreach (Transform child in _container)
            Destroy(child.gameObject);

        //foreach (var item in items)
        //{
        //    var id = item.ID;
        //    storageCells[id] = Instantiate(_storageCellTemplate, _container);
        //    storageCells[id].Render(item);
        //}

        for (int i = 0; i < items.Count; i++)
        {
            //var id = items[i].ID;
            //storageCells[id] = Instantiate(_storageCellTemplate, _container);
            storageCells.Add(Instantiate(_storageCellTemplate, _container));
            storageCells[i].Render(items[i]);
        }

        //items.ForEach (item => 
        //{
        //    var cell = Instantiate(_storageCellTemplate, _container);
        //    cell.Render(item);
        //}
        //);

    }

    //public static void RemoveItem()
    //{
    //    OnItemRemove?.Invoke();
    //}

    //public static void AddItem()
    //{
    //    OnItemAdd?.Invoke();
    //}
}
