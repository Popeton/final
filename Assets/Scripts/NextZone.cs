using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextZone : MonoBehaviour
{
    [SerializeField] Transform newzone,vrtk;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            vrtk.position = newzone.position;
            other.gameObject.SetActive(false);
        }
    }
}
