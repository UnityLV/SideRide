using System;
using UnityEngine;
using UnityEngine.Events;


public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private UnityEvent _onCollided;

    private void OnCollisionEnter2D(Collision2D col)
    {
        _onCollided?.Invoke();
    }

}