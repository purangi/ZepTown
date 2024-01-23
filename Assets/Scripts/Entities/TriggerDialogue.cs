using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    [SerializeField] GameObject E_key;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("enter");
        E_key.SetActive(true);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("stay");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("exit");
        E_key.SetActive(false);
    }
}
