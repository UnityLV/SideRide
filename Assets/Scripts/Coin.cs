using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private CoinFollow _coinFollow;

    private void OnTriggerEnter2D(Collider2D other)
    {
        _coinFollow.SetTarget(other.transform);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _coinFollow.ResetTarget();
    }
}