using Unity.VisualScripting;
using UnityEngine;





public class SinusoidalMovement : MonoBehaviour
{
    [SerializeField] private float _amplitude = 1f;
    [SerializeField] private float _frequency = 1f;
    [SerializeField] private float _speed = 1f;

    private Vector3 _startPosition;
    private float _01MoveOffset;

    void Start()
    {
        _startPosition = transform.position;
        _01MoveOffset = Random.Range(-1f, 1f);
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float newY = _startPosition.y + _amplitude * Mathf.Sin((Time.time + _01MoveOffset) * _frequency);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}