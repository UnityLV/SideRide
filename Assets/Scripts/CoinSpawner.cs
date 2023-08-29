using UnityEngine;

public class CoinSpawner : BaseSpawner
{
    [SerializeField] private float _spawnInterval = 2;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnCoin), 0, _spawnInterval);
    }

    private void SpawnCoin()
    {
        Spawn();
    }
}