using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterSystem : MonoBehaviour
{
    [SerializeField] float velocidad = 5f; 
    [SerializeField] float tiempoTotal; 
    private float tiempoTranscurrido = 0f; 

    private void Update()
    {
        tiempoTranscurrido += Time.deltaTime; 

        if (tiempoTranscurrido <= tiempoTotal)
        {
            float posY = Mathf.Lerp(-3f, 2.5f, tiempoTranscurrido / tiempoTotal); 
            transform.position = new Vector3(transform.position.x, posY, transform.position.z); 

            if (Mathf.Approximately(posY, 2.5f))
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
