using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    Outline outline;
    public string message;
    public UnityEvent onInteraction;
    void Start()
    {
        outline= GetComponent<Outline>();
        disableOutline();
    }

    public void interaction()
    { 
        onInteraction.Invoke();
    }

    public void disableOutline()
    { 
        outline.enabled = false;
    }
    
    public void enableOutline()
    { 
        outline.enabled = true;
    }
}
