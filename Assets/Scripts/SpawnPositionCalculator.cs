using System.Collections.Generic;
using UnityEngine;

public class SpawnPositionCalculator
{
    private readonly float _spawnRadius;
    private readonly Transform _transform;
    
    public SpawnPositionCalculator(float spawnRadius, Transform transform)
    {
        _spawnRadius = spawnRadius;
        _transform = transform;
    }

    public IEnumerable<Vector3> GetPositions(int count)
    {
        Vector3[] positions = new Vector3[count];

        for (int i = 0; i < positions.Length; i++)
        {
            positions[i] = (Vector3)(Random.insideUnitCircle * _spawnRadius) + _transform.position;
        }
        return positions;
    }
}