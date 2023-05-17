using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Door : MonoBehaviour
{
    [SerializeField] int correctKeyId; // id de la llave correcta
    [SerializeField] GameObject door;
    public List<Key> keys; // lista de llaves
    private bool isOpen = false; // indica si la puerta está abierta

    [SerializeField] Animator animator;
    void Start()
    {
        // Selecciona aleatoriamente una llave como la correcta
        correctKeyId = Random.Range(0, keys.Count);
    }

    public void Unlock(Key key)
    {
        // Si la puerta ya está abierta, no hacer nada
        if (isOpen) return;

        // Comprueba si la llave es la correcta
        if (key.id == correctKeyId)
        {
            Debug.Log("Puerta abierta con la llave #" + key.id);
            isOpen = true;
            UnlockDoor();
            // Aquí iría el código para abrir la puerta
        }
        else
        {
            Debug.Log("Llave incorrecta #" + key.id);
        }
    }

    void UnlockDoor()
    {
        animator.SetBool("unlock", true);
        
    }
}
