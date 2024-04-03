using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    //on peut aller chercher des fonction dans d'autres codes
    public PlayerMovement getKey;
    public bool PlayerHasYellowKey;

    public void Awake()
    {
        //getkey va aller chercher le GO dans le scrpt de playermovement
        getKey = GameObject.FindObjectOfType<PlayerMovement>();
        PlayerHasYellowKey = getKey.HasYellowKey;

        if (PlayerHasYellowKey == true)
        {
            Destroy(this.gameObject);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //on active la fonction du joueur, la key devient true
            collision.gameObject.GetComponent<PlayerMovement>().GetYellowKey();
            Destroy(this.gameObject);
        }
    }


}