using System;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _smoothSpeed = 5f; 

    private void Update()
    {
        if (_target != null)
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, _target.position, _smoothSpeed * Time.deltaTime);

            transform.position = newPosition;
        }
    }
    

}