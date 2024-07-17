using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator animator;

    public void DoorOpen()
    {
        animator.SetBool("character_nearby", true);
        StartCoroutine (doorClosing());

    }

    private IEnumerator doorClosing()
    {
        yield return new WaitForSeconds(3);
        animator.SetBool("character_nearby", false);
    }
}
