using System;
using UnityEngine;


public class PlayerFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _smoothSpeed = 5f;

    private void Update()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, _target.position, _smoothSpeed * Time.deltaTime);

        transform.position = newPosition;
    }
}