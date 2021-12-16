using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    [SerializeField] private Transform target;

    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        transform.position = target.position + _offset;
    }
}
