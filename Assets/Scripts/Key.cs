using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    //on peut aller chercher des fonction dans d'autres codes mdr je savais po
    public PlayerMovement getKey;
    public bool PlayerHasKey;

    public void Awake()
    {
        //getkey va aller chercher le GO dans le scrpt de playermovement
        getKey = GameObject.FindObjectOfType<PlayerMovement>();
        PlayerHasKey = getKey.HasKey;

        if (PlayerHasKey == true)
        {
            Destroy(this.gameObject);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //on active la fonction du joueur, la key devient true
            collision.gameObject.GetComponent<PlayerMovement>().GetKey();
            Destroy(this.gameObject);
        }
    }


}