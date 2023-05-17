using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextZone : MonoBehaviour
{
    [SerializeField] Transform newzone;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = newzone.position;
        }
    }
}
