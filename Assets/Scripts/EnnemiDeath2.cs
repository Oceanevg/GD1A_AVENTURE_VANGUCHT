using UnityEngine;

public class EnnemiDeath2 : MonoBehaviour
{


    public GameObject objectToDestroy;
    public GameObject loot2;

    private void Awake()
    {
        objectToDestroy = GameObject.FindWithTag("Ennemi");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //instantiate c'est pour creer un truc dans la scene, l� c'est loot
        //transform.position c'est la position qu'on veut du coup l'ennemi et quaternion c'est la rotation

        if (collision.CompareTag("Look"))
        {
            Instantiate(loot2, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}