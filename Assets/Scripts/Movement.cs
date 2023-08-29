using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}