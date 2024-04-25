using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lance : MonoBehaviour
{

    public PlayerMovement getLance;
    public bool PlayerHasLance;
    public GameObject objectToDestroy;

    private void Awake()
    {
        objectToDestroy = GameObject.FindWithTag("Ennemi");



    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

