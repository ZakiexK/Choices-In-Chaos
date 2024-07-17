using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{

    public TMPro.TMP_Text tmpro;
    public void increaseScore()
    { 
        GameManager.instance.incrementScore();
        Debug.Log(GameManager.instance.score);
    }

    public void updateScore()
    {
        tmpro.text = GameManager.instance.score.ToString();
    }
}
