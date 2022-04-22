using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SaberAnim: MonoBehaviour
{
    public Animator bladeanim;
    private bool isEnabled = false;

    public InputActionReference bladeToggleRefence;
    void Start()
    {
        bladeToggleRefence.action.performed += ButtonPressed;
    }

    private void OnDestroy()
    {
        bladeToggleRefence.action.performed -= ButtonPressed;
    }
    public void ButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            ToggleBlade();
        }
    }
    private void ToggleBlade()
    {
        isEnabled = !isEnabled;
        bladeanim.SetBool("IsOn", isEnabled);
    }
}
