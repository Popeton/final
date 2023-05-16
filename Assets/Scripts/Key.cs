using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public int id; // id de la llave

    private void OnTriggerEnter(Collider other)
    {
        Door door = other.GetComponent<Door>();
        if (door != null)
        {
            door.Unlock(this);
        }
    }

    private void Start()
    {
        
    }
}
