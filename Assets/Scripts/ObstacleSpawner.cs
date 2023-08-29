using System;
using System.Net.Mail;
using UnityEngine;


public class ObstacleSpawner : BaseSpawner
{
    [SerializeField] private float _spawnInterval = 2;
    [SerializeField] private float _increaseInterval = 10;
    private int _obstacleCount = 1;

    private void Start()
    {
        InvokeRepeating(nameof(CreateObstacles), 0, _spawnInterval);
        InvokeRepeating(nameof(IncreaseCount), _increaseInterval, _increaseInterval);
    }

    private void IncreaseCount()
    {
        _obstacleCount++;
    }

    private void CreateObstacles()
    {
        Spawn(_obstacleCount);
    }
}