using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHands : MonoBehaviour
{
    public InputActionReference gripReference, triggerReference;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

        // Attach the event listeners
        gripReference.action.started += GripPressed;
        gripReference.action.canceled += GripCanceled;
        triggerReference.action.started += TriggerPressed;
        triggerReference.action.canceled += TriggerCanceled;
    }

    private void OnDestroy()
    {
        // Detach the event listeners to prevent memory leaks
        gripReference.action.started -= GripPressed;
        gripReference.action.canceled -= GripCanceled;
        triggerReference.action.started -= TriggerPressed;
        triggerReference.action.canceled -= TriggerCanceled;
    }

    private void GripPressed(InputAction.CallbackContext context)
    {
        Debug.Log("Grip Pressed");
        anim.SetBool("GripPressed", true);
    }

    private void GripCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("Grip Canceled");
        anim.SetBool("GripPressed", false);
    }

    private void TriggerPressed(InputAction.CallbackContext context)
    {
        Debug.Log("Trigger Pressed");
        anim.SetBool("TriggerPressed", true);
    }

    private void TriggerCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("Trigger Canceled");
        anim.SetBool("TriggerPressed", false);
    }
}