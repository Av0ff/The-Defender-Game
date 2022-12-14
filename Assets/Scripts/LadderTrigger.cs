using UnityEngine;

public class LadderTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _ladderFloor;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetAxis("Vertical") != 0 && collision.GetComponent<Player>())
        {
            var vertical = Input.GetAxisRaw("Vertical");
            collision.transform.Translate(new Vector3(0, vertical, 0) * Time.deltaTime);
            _ladderFloor.SetActive(false);
            collision.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.GetComponent<Player>())
        {
            _ladderFloor.SetActive(true);
            collision.GetComponent<Rigidbody2D>().gravityScale = 5;
        }

    }
}
