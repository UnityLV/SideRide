using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _spawnRadius;
    private SpawnPositionCalculator _positionCalculator;
    private readonly int _lifeTime = 6;

    private void Awake()
    {
        _positionCalculator = new SpawnPositionCalculator(_spawnRadius, transform);
    }

    protected void Spawn(int count = 1)
    {
        IEnumerable<Vector3> positions = _positionCalculator.GetPositions(count);

        foreach (Vector3 position in positions)
        {
            var instance = Instantiate(_prefab, position, Quaternion.identity);
            Destroy(instance, _lifeTime);
        }
    }
}