using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    public UnityEvent pickUpKey;


    void Start()
    {
        //pickUpKey.AddListener(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().incrementScore);
        pickUpKey.AddListener(GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>().UpdateScore);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pickUpKey.Invoke();
            Destroy(gameObject);
        }
    }

   
}
