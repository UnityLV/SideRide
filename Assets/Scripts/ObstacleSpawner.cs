using System;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    [SerializeField] private float _spawnRadius;
    
    [SerializeField] private float _spawnInterval = 2;
    [SerializeField] private float _increaseInterval = 10;
    private int _obstacleCount = 1;
    private readonly int _lifeTime = 6;
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

    private void Spawn(int count)
    {
        IEnumerable<Vector3> positions = GeneratePositions(count);

        foreach (Vector3 position in positions)
        {
            var instance = Instantiate(_prefab, position, Quaternion.identity);
            Destroy(instance, _lifeTime);
        }
    }

    private IEnumerable<Vector3> GeneratePositions(int count)
    {
        Vector3[] positions = new Vector3[count];

        for (int i = 0; i < positions.Length; i++)
        {
            positions[i] =  (Vector3)(Random.insideUnitCircle * _spawnRadius) + transform.position;
        }
        return positions;
    }
}