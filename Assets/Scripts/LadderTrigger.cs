using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _ladderFloor;

    private bool _isMoving;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetAxis("Vertical") != 0)
        {
            var vertical = Input.GetAxisRaw("Vertical");
            collision.transform.Translate(new Vector3(0, vertical, 0) * Time.deltaTime);
            _ladderFloor.SetActive(false);
            collision.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _ladderFloor.SetActive(true);
        _isMoving = false;
        collision.GetComponent<Rigidbody2D>().gravityScale = 5;
    }
}
