using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    Interactable interactable;

    private void OnTriggerEnter(Collider other)
    {
        interactable = other.gameObject.GetComponent<Interactable>();
        interactable.enableOutline();
        HUDController.instace.enableTextInteraction(interactable.message);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            interactable.disableOutline();
            interactable.interaction();
            HUDController.instace.disableTextInteraction();
            interactable = null;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        interactable.disableOutline();
        HUDController.instace.disableTextInteraction();
        interactable = null;
    }
}
