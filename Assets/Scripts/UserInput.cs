using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UserInput : MonoBehaviour
{
    public event UnityAction InputDetected;

    private const KeyCode InteractedKey = KeyCode.Space;

    private void Update()
    {
        if (IsInputDetected())
        {
            InputDetected?.Invoke();
        }
    }

    private bool IsInputDetected()
    {
        return Input.GetKeyDown(InteractedKey) || IsAnyMouseButtonPressed();
    }

    private bool IsAnyMouseButtonPressed()
    {
        return Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2);
    }
}