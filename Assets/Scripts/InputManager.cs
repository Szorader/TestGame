using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static bool EscWasPressed;

    private PlayerInput _playerInput;
    private InputAction _escAction;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _escAction = _playerInput.actions["QUIT"];
    }

    private void Update()
    {
        EscWasPressed = _escAction.WasPressedThisFrame();
    }
}