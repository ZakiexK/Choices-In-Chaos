using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject UIobject;
    public int score { get; private set; }
    public int maxobj;

    private void Awake()
    {
        instance = this;
    }

    public void incrementScore()
    {
        score++;
        Debug.Log(score);
        if (score == maxobj)
        {
            UIobject.SetActive(true);
        }
    }

  
}
