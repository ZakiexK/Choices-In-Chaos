using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    public static HUDController instace;

    private void Awake()
    {
        instace = this;
    }

    [SerializeField] TMP_Text interactiontext;

    public void enableTextInteraction(string text)
    { 
        interactiontext.text = text + "(E)";
        interactiontext.gameObject.SetActive(true);
    }

    public void disableTextInteraction()
    { 
        interactiontext.gameObject.SetActive(false);
    }
}
