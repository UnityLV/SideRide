using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;


public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private UnityEvent _onCollidedObstacle;
    [SerializeField] private UnityEvent<GameObject> _onCollidedCoin;
    private const int ObstacleLayer = 7;
    private const int CoinLayer = 6;

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.layer);
        if (col.gameObject.layer == ObstacleLayer)
        {
            _onCollidedObstacle?.Invoke();
        }

        if (col.gameObject.layer == CoinLayer)
        {
            _onCollidedCoin?.Invoke(col.gameObject);
        }
    }
}