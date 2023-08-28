using System;
using UnityEngine;


public class GameStarter : MonoBehaviour
{
    public bool IsGameStarted { get; private set; }
    public void StartGame()
    {
        IsGameStarted = true;
        Debug.Log("Game started");
    }
}