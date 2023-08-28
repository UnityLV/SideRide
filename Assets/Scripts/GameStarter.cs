using System;
using UnityEngine;
using UnityEngine.Events;


public class GameStarter : MonoBehaviour
{
    [SerializeField] private UnityEvent _onGameStarted;
    public bool IsGameStarted { get; private set; }
    public void StartGame()
    {
        IsGameStarted = true;
        gameObject.SetActive(true);
        _onGameStarted?.Invoke();
        Debug.Log("Game started");
    }
}