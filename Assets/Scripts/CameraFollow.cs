using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform _character;

    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _character.position;
    }

    private void LateUpdate()
    {
        transform.position = _character.position + _offset;
    }
}
