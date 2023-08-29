using UnityEngine;
using UnityEngine.Events;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private UnityEvent<string> _coinsCountUpdated;
    private int _coinCount = 0;
    
    public void CollectCoin(GameObject coin)
    {
        Destroy(coin);
        _coinCount++;
        _coinsCountUpdated?.Invoke(_coinCount.ToString());
    }
}