using UnityEngine;

public class TriggerStairs : MonoBehaviour
{
    [SerializeField]
    private GameObject _secondFloor;

    [SerializeField]
    private GameObject _stairs;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F) && collision.GetComponent<Player>())
        {
            _stairs.SetActive(true);
            _secondFloor.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            _stairs.SetActive(false);
            _secondFloor.SetActive(true);
        }
    }
}
