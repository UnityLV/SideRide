using UnityEngine;


[RequireComponent( typeof(Rigidbody2D))]  
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveUpForce;
    private Rigidbody2D _rigidbody;
    private readonly Vector2 _forceDirection = Vector2.up;
     
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void MoveUp()
    {
        Vector2 force = _forceDirection * _moveUpForce;
        _rigidbody.AddForce(force);
    }

}