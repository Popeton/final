using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleContainer : MonoBehaviour
{
    [SerializeField]  int bottleCount = 0;
    [SerializeField] GameObject[] bottles;
    [SerializeField] GameObject nextClue;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bottle"))
        {
            //var parent = collision.transform.parent;
            collision.gameObject.transform.parent.gameObject.SetActive(false);
            bottles[bottleCount].gameObject.SetActive(true);
            bottleCount++;
            print(collision.gameObject);
            if (bottleCount == 3)
            {
                nextClue.SetActive(true);
            }
        }
    }
}
