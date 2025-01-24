using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public static event Action OnPausePressed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnPausePressed?.Invoke();
        }
    }
}