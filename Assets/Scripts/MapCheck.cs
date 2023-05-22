using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCheck : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
