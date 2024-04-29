using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key3 : MonoBehaviour
{
    //on peut aller chercher des fonction dans d'autres codes


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //on active la fonction du joueur, la key devient true
           
            Destroy(this.gameObject);
        }
    }


}