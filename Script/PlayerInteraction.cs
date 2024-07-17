using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float PlayerReach = 2f;
    Interactable currentinteractable;

    void Update()
    {
        checkinteraction();
        if (Input.GetKey(KeyCode.E) && currentinteractable != null)
        {
            currentinteractable.interaction();
        }

    }

    void checkinteraction()
    {
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        if (Physics.Raycast(ray,out hit, PlayerReach))
        {
            if (hit.collider.tag == "Interactable")
            {
                Interactable newInteractable = hit.collider.GetComponent<Interactable>();
                if (currentinteractable && newInteractable != currentinteractable)
                {
                    currentinteractable.disableOutline();
                }

                if (newInteractable.enabled)
                {
                    setNewInteractable(newInteractable);
                }
                else
                {
                    disableCurrentInteraction();
                }
            }
            else
            {
                disableCurrentInteraction();
            }
       }

        
    }

    void setNewInteractable(Interactable newInteractable) 
    {
        currentinteractable = newInteractable;
        currentinteractable.enableOutline();
        HUDController.instace.enableTextInteraction(currentinteractable.message);
    }

    void disableCurrentInteraction()
    {
        HUDController.instace.disableTextInteraction();
        if (currentinteractable)
        {
            currentinteractable.disableOutline();
            currentinteractable = null;
        }
    }

}
