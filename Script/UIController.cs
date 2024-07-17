using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMesh;
    public void UpdateScore()
    {
        textMesh.text = GameManager.instance.score.ToString() + " / " + GameManager.instance.maxobj.ToString();
    }
}
