using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerStay(Collider col)
    {

        Debug.Log("Enter");

        if (col.gameObject.tag == "Bomb")
        {
            Debug.Log("This is an item!");
        }

    }
}