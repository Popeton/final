using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextZone : MonoBehaviour
{
    [SerializeField] Transform newzone,vrtk;
   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            vrtk.position = newzone.position;
            collision.gameObject.SetActive(false);
        }
    }
}
