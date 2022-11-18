using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1_Ball : MonoBehaviour
{
    private EXERCISE1 EXERCISE1_Script;

    void Start()
    {
        //At the begginig we asked to find the other script
        EXERCISE1_Script = FindObjectOfType<EXERCISE1>();
    }

    private void OnMouseDown()
    {
        //Destroy rhe gameobject
        EXERCISE1_Script.Enemies--;
        Destroy(gameObject);
    }
}
