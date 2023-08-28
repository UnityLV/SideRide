using UnityEngine;

public class TrailEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _scaler;
    private ParticleSystem.VelocityOverLifetimeModule _velocityModule;


    private void Start()
    {
        _velocityModule = _particleSystem.velocityOverLifetime;
    }

    private void FixedUpdate()
    {
        float  targetVelocity = _rigidbody2D.velocity.y * _scaler;

        _velocityModule.yMultiplier =targetVelocity;
    }
}