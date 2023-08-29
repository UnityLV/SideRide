using UnityEngine;

public class CoinFollow : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    private Transform _target;

    private void Update()
    {
        if (_target != null)
        {
            Vector3 direction = _target.position - transform.position;
            Vector3 newPosition = transform.position + direction.normalized * _moveSpeed * Time.deltaTime;

            transform.position = newPosition;
        }
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    public void ResetTarget()
    {
        _target = null;
    }
}