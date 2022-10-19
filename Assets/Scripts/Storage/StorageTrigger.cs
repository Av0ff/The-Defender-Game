using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StorageTrigger : MonoBehaviour
{
    [SerializeField]
    private Image _scrollBar;

    private void Start()
    {
        foreach (var item in Storage.storageCells)
        {
            item.RemItem();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            _scrollBar.enabled = true;
            foreach(var item in Storage.storageCells)
            {
                item.AdItem();
            }
        }
            
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            _scrollBar.enabled = false;
            foreach(var item in Storage.storageCells)
            {
                item.RemItem();
            }
        }
            
    }
}
