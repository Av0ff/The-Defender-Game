using UnityEngine;

public class MoveOnStairs : MonoBehaviour
{
    [SerializeField]
    private Collider2D _stairs;

    [SerializeField]
    private Collider2D _floor;

    public bool isStairsActive;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            isStairsActive = true;
            StairsActive();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isStairsActive = false;
        StairsActive();
    }

    private void StairsActive()
    {
        if(isStairsActive)
        {
            _stairs.gameObject.SetActive(true);
            _floor.gameObject.SetActive(false);
        }
        else
        {
            _stairs.gameObject.SetActive(false);
            _floor.gameObject.SetActive(true);
        }
    }
}
