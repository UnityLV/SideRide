using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class InputEventScheduler : MonoBehaviour
{
    [SerializeField] private UserInput _userInput;
    
    [SerializeField] private GameStarter _gameStarter;
    [SerializeField] private PlayerMovement _playerMovement;

    void Start()
    {
        _userInput.InputDetected += OnInputDetected;
    }

    void OnDestroy()
    {
        _userInput.InputDetected -= OnInputDetected;
    }

    void OnInputDetected()
    {
        if (_gameStarter.IsGameStarted == false)
        {
            _gameStarter.StartGame();
        }
        
        _playerMovement.MoveUp();
    }
}