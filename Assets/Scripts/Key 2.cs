using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2 : MonoBehaviour
{
    //on peut aller chercher des fonction dans d'autres codes
    public PlayerMovement getKey;
    public bool PlayerHasRedKey;

    public void Awake()
    {
        //getkey va aller chercher le GO dans le scrpt de playermovement
        getKey = GameObject.FindObjectOfType<PlayerMovement>();
        PlayerHasRedKey = getKey.HasRedKey;

        if (PlayerHasRedKey == true)
        {
            Destroy(this.gameObject);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //on active la fonction du joueur, la key devient true
            collision.gameObject.GetComponent<PlayerMovement>().GetRedKey();
            Destroy(this.gameObject);
        }
    }

}
